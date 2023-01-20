using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Day20.Models;

namespace Day20.Utils
{
    public class WebAPIUtils
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<T> GetProductAsync<T>(string path)
        {
            T product = default(T);

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            else 
                throw new Exception(response.ReasonPhrase);
            
            return product;
        }
    }
}