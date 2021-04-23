using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Time
{
    class Pizza
    {
        private int diameter;
        private string toppings;
        private double prijs;

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (value >=10 && value <= 30)
                {
                    diameter = value;
                }
            }
        }

        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }

        public double Prijs
        {
            get
            {
                return prijs;
            }
            set
            {
                if (value > 0)
                {
                    prijs = value;
                }
            }
        }

        public void SoortPizza()
        {
            Console.WriteLine($"Topping: {Toppings}");
            Console.WriteLine($"Diameter: {Diameter}");
            Console.WriteLine($"Prijs: {Prijs}\n");

        }
    }
}
