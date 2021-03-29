using System;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza peperoni = new Pizza();
            peperoni.Toppings = "pepers";
            peperoni.Price = 43;
            peperoni.Diameter = 5;

            peperoni.ShowPizza();
        }
    }
}
