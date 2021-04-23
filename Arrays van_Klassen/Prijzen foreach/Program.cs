using System;

namespace Prijzen_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[5];
            for(int i =0; i < prijzen.Length; i++)
            {
                Console.WriteLine("Geef een prijs: ");
                prijzen[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            foreach (double _prijs in prijzen)
            {
                if (_prijs >= 5)
                {
                    Console.WriteLine(_prijs);
                }
            }
        }
    }
}
