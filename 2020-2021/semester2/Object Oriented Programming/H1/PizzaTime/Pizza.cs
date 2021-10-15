using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaTime
{
    class Pizza
    {
        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set 
            {
                if (value != "")
                {
                    toppings = value;
                }
                else
                    Console.WriteLine("geen topping");
                    
            
            }
        }
        private int diamter;

        public int Diameter
        {
            get { return diamter; }
            set 
            {
                if (value > 0){ diamter = value;}
                else { Console.WriteLine("neg diamter"); }    
            }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set 
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                    Console.WriteLine("neg price");
                    
            }
        }

        public void ShowPizza()
        {
            Console.WriteLine($"toping: {Toppings}  ");
            Console.WriteLine($"diamter: {Diameter} ");
            Console.WriteLine($"price {Price}");
        }


    }
}
