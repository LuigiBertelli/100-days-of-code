using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Day74
{
    internal interface Config
    {
        string SHOW_PROFILE_URL { get; }
        string TOKEN { get; }
    }

    internal class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public string description { get; set;}
        public int followers_count { get; set; }
        public int friends_count { get; set; }
        public string created_at { get; set; }
        public bool default_profile_image { get; set; }
        public string profile_image_url_https { get; set;}
        public int statuses_count { get; set; }
    }
    
    public class Cattlemeter
    {
        private static HttpClient client = new HttpClient();

        public async static Task<string> Scale(string arroba)
        {
            var json = File.ReadAllText(@"./appconfig.json");
            var config = JsonSerializer.Deserialize<Config>(json);

            int meter = 0;

            var user = new User();

            HttpResponseMessage response = await client.GetAsync(config.SHOW_PROFILE_URL);


            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                user = JsonSerializer.Deserialize<User>(resp);
            }

            if (user.default_profile_image)
                meter += 10;
            
            //Need to do the profile image check

            if (string.IsNullOrEmpty(user.description))
                meter += 10;

            //Need to do the duplicated tweets check

            if (string.Compare(user.name, user.screen_name) < 40)
                meter += 10;

            //Nedd to do the tweets coheretion check

            if(user.followers_count < 100)
                meter += 10;

            if(user.friends_count == 2001)
                meter += 10;

            if (user.statuses_count > 100000)
                meter += 10;


            if (meter > 100)
                return @"Too much cattle! 🐮";

            if (meter > 80)
                return "It's definetely a cattle ! Avoid it !";

            if (meter > 20)
                return "Sounds like a cattle (muhhhh)";

            return "Not a cattle";

        }
    }
}
