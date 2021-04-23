using System;
using System.Collections.Generic;

namespace Het_dierenrijk
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dier = new Animal();
            Dog hond = new Dog();
            Bird vogel = new Bird();
            dier.ToonInfo();
            Console.WriteLine("\n");
            hond.ToonInfo();
            Console.WriteLine("\n");
            vogel.ToonInfo();
            Console.ReadLine();

            //Animal[] alledieren = new Animal();
            List<Animal> alleDieren = new List<Animal>();
            alleDieren.Add(dier);
            alleDieren.Add(hond);
            alleDieren.Add(vogel);

            foreach (var item in alleDieren)
            {
                item.ToonInfo();
                Console.WriteLine("\n");
            }
        }
    }
}
