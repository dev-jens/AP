using System;
using System.Collections.Generic;
using System.Text;

namespace Baeten_Jens_OOP2
{
    class GPSLocation
    {
        Random r = new Random();
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public GPSLocation()
        {
            Latitude = r.Next(1,10);
            Longitude = r.Next(1, 10);
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
}
