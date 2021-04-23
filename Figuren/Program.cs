using System;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();
            Rechthoek rechthoek2 = new Rechthoek();
            Driehoek driehoek1 = new Driehoek();
            Driehoek driehoek2 = new Driehoek();

            driehoek1.Hoogte = 10;
            driehoek1.Basis = 20;
            rechthoek1.Lengte = 10;
            rechthoek1.Breedte = 20;
            driehoek2.Hoogte = 5;
            driehoek2.Basis = 20;
            rechthoek2.Lengte = 20;
            rechthoek2.Breedte = 30;

            Console.WriteLine($"De oppervlakte van rechthoek 1: {rechthoek1.ToonOppervlakte()}");
            Console.WriteLine($"De oppervlakte van rechthoek 2: {rechthoek2.ToonOppervlakte()}");
            Console.WriteLine($"De oppervlakte van driehoek 1: {driehoek1.ToonOppervlakte()}");
            Console.WriteLine($"De oppervlakte van driehoek 2: {driehoek2.ToonOppervlakte()}");
        }
    }
}
