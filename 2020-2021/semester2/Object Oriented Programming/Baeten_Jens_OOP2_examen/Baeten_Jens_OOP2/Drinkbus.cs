using System;
using System.Collections.Generic;
using System.Text;

namespace Baeten_Jens_OOP2
{
    class Drinkbus : SportItem, ITrackable
    {
        public GPSLocation GetCurrentLocation()
        {
            GPSLocation gps = new GPSLocation();

            return gps;
        }

        public override string ToString()
        {
            return "een drinkbus";
        }

    }
}
