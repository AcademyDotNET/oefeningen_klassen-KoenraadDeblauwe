using System;
using System.Collections.Generic;
using System.Text;

namespace Klassen_en_opbjecten_introductie
{
    class Resultaat
    {
        public int Percentage { get; set; }
        public void SetPercentage()
        {
            if (Percentage>0 && Percentage < 50)
            {
                Console.WriteLine("Niet geslaagd.");

            }
            else if (Percentage > 49 && Percentage < 68)
            {
                Console.WriteLine("Voldoende.");
            }
            else if (Percentage >=68 && Percentage < 75)
            {
                Console.WriteLine("Onderscheiding.");
            }
            else if (Percentage >75 && Percentage <= 85)
            {
                Console.WriteLine("Grote onderscheiding.");
            }
            else if (Percentage > 85 && Percentage <= 100)
            {
                Console.WriteLine("Grootste onderscheiding.");
            }
            else
            {
                Console.WriteLine("Verkeerde ingave.");
            }
        }
    }
}
