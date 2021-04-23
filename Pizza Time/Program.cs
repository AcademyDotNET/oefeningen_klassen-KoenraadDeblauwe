using System;

namespace Pizza_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizzaMargarita = new Pizza();
            pizzaMargarita.Diameter = 15;
            pizzaMargarita.Toppings = "Tomaat";
            pizzaMargarita.Prijs = 10;
            Pizza pizzaDiabolo = new Pizza();
            pizzaDiabolo.Diameter = 30;
            pizzaDiabolo.Toppings = "Salami";
            pizzaDiabolo.Prijs = 15;
            Pizza pizzaZeevruchten = new Pizza();
            pizzaZeevruchten.Diameter = 20;
            pizzaZeevruchten.Toppings = "Vis";
            pizzaZeevruchten.Prijs = 17;

            pizzaZeevruchten.SoortPizza();
            pizzaMargarita.SoortPizza();
            pizzaDiabolo.SoortPizza();
        }
    }
}
