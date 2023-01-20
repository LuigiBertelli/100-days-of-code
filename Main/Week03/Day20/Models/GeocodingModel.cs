using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day20.Models
{
    public class GeocodingModel
    {
        public GeocodeModel[] Results {get; set;}

        public class GeocodeModel
        {
            public GeometryModel Geometry {get; set;}
        } 

        public class GeometryModel
        {
            public LocationModel Location {get; set;}
        }
    }
}