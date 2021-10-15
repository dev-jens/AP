using System;
using System.Collections.Generic;
using System.Text;

namespace Baeten_Jens_OOP2
{
    class Rugzak : ITrackable
    {
        private Dictionary<string,SportItem> rugzakInhoud = new Dictionary<string, SportItem>();
        
        public Dictionary<string,SportItem> RugzakInhoud
        {
            get { return rugzakInhoud; }
            set { rugzakInhoud = value; }
        }

        private AdvancedGPSLocation gpsLocation = new AdvancedGPSLocation();
        private SportItem sportItem = new SportItem();
        private Drinkbus drinkBus = new Drinkbus();

        public GPSLocation GetCurrentLocation()
        {
            
            return gpsLocation;
        }

        public override string ToString()
        {
            string message = $"Rugzak op locatie:\t{GetCurrentLocation()}\n" +
                             $"Met inhoud:\n";
            foreach (var item in rugzakInhoud)
            {
                if (item.Value is Drinkbus)
                {
                  
                    message += $"\t\t{item.Key} ({drinkBus.ToString()})\n" +
                        $"\t\t\t-Laatste locatie is {drinkBus.GetCurrentLocation()}\n";
                }
                else
                {
                    message += $"\t\t {item.Key} ({sportItem.ToString()})\n" +
                        $"\t\t\t-geen tracker\n";
                }
            }

            return message;
                 
        }

        public void Visualiseer()
        {
           
            foreach (var item in rugzakInhoud)
            {
                if(item.Value is Drinkbus)
                {
                    Console.SetCursorPosition(drinkBus.GetCurrentLocation().Longitude, drinkBus.GetCurrentLocation().Latitude);
                    Console.Write("D");
                    
                } 
                
            }
            Console.SetCursorPosition(this.GetCurrentLocation().Longitude, this.GetCurrentLocation().Latitude);
            Console.Write("R");

        }

    }
}
