using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Day20.Utils;

namespace Day20.Models
{
    public class CityModel
    {

        [JsonProperty("matched_substrings")]
        protected MatchedSubstringsModel[] MatchedSubstrings { get; set;}

        [JsonProperty("description")]
        public string Name {get; set;}

        public string Place_id { get; set;}

        public LocationModel Location {get; set;}
        
        public decimal Score {
            get{
                decimal score = 0m;
                foreach(MatchedSubstringsModel msm in MatchedSubstrings)
                    score += (decimal) msm.Length / Name.Length;

                return decimal.Round(score, 1);
            }
        }

    }

    public class MatchedSubstringsModel
    {
        public int Length {get; set;}
        public int Offset {get; set;}
    }

    public class TermModel
    {
        public int Offset {get; set;}
        public string Value {get; set;}   
    }
}