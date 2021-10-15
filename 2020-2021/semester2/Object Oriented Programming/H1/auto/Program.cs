using System;

namespace auto
{

    class auto 
    {
        public gps getLocation()
        {
            gps garmin = new gps() { longitude = 56.6, lengt = 33.44 };
            return garmin;
        }

    }
    class gps
    {
        public double longitude { get; set; }
        public double lengt { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            auto car = new auto();
            Console.Write(car.getLocation());
        }
    }
}
