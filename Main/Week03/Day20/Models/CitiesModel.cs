using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace Day20.Models
{
    public class CitiesModel
    {
        [JsonProperty("predictions")]
        public CityModel[] Suggestions {get; set;}

        public CitiesModel()
        {
            Suggestions = new CityModel[]{};
        }
    }
}