using System;

namespace Klassen_en_opbjecten_introductie
{
    class Program
    {
        static void Main(string[] args)
        {

            Resultaat mijnBeoordeling = new Resultaat();
            Console.WriteLine("Geef uw percentage: ");
            int percentage=int.Parse(Console.ReadLine());
            mijnBeoordeling.Percentage = percentage;
            mijnBeoordeling.SetPercentage();
        }
    }
}
