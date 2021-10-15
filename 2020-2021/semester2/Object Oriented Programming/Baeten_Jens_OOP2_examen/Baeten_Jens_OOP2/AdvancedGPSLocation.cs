using System;
using System.Collections.Generic;
using System.Text;

namespace Baeten_Jens_OOP2
{
    class AdvancedGPSLocation :GPSLocation
    {
        public int Height { get; set; }

        public AdvancedGPSLocation(int latitude , int longitude, int height)
        {
            Latitude = latitude;
            Longitude = longitude;
            Height = height;
        }
        public AdvancedGPSLocation() : base()
        {
            Height = 1;
        }

        public override string ToString()
        {
            return base.ToString() + $" Height: {Height}";
        }
    }
}
