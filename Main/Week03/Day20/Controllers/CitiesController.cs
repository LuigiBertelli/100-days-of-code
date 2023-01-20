using Microsoft.AspNetCore.Mvc;
using System.Web;
using Day20.Utils;
using Day20.Models;

namespace Day20.Controllers;

[ApiController]
[Route("[controller]")]
public class CitiesController : ControllerBase
{
    
    private const string GOOGLE_MAPS_API_KEY = "AIzaSyDROxnZkP4uANOfmlhoe6Ts6Mp6asFwM7M";

    private const string GEOLOCATION_API_URL = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}{1}&types=geocode&key={2}";

    private const string GEOCODING_API_URL = "https://maps.googleapis.com/maps/api/geocode/json?place_id={0}&key={1}";

    private readonly ILogger<CitiesController> _logger;

    public CitiesController(ILogger<CitiesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Suggestions")]
    public CityModel[] Get(string name, double? longitude, double? latitude)
    {
        try
        {

            var additionalParams = string.Empty;

            if(longitude != null && latitude != null)
                additionalParams = $"&location={HttpUtility.UrlEncode(latitude.ToString())}%2C{HttpUtility.UrlEncode(longitude.ToString())}";

            
            var urlGetCities = string.Format(GEOLOCATION_API_URL, name, additionalParams, GOOGLE_MAPS_API_KEY);
            var results = WebAPIUtils.GetProductAsync<CitiesModel>(urlGetCities);

            CityModel[] suggestions = results.Result.Suggestions;

            for(int i = 0; i < suggestions.Length; i++)
            {
                var urlGetCoordinates = string.Format(GEOCODING_API_URL, suggestions[i].Place_id, GOOGLE_MAPS_API_KEY);

                var resultsGeocoding = WebAPIUtils.GetProductAsync<GeocodingModel>(urlGetCoordinates);
                
                GeocodingModel geoResults = resultsGeocoding.Result;

                var geocode = geoResults.Results.FirstOrDefault();

                suggestions[i].Location = geocode.Geometry.Location;
            }

            return suggestions.OrderBy(x => -x.Score).ToArray();
        } catch(Exception ex) {
            Console.WriteLine($"Error: {ex.Message} - {ex.StackTrace.ToString()}");

            return new CityModel[] {};
        }
    }
}
