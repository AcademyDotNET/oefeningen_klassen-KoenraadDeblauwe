using System;

namespace Sports
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string naam, reeks;
            int mutsnummer;
            
            Waterpolospeler speler1 = new Waterpolospeler();
            Console.WriteLine("\nInstellen speler 1");
            naam = InvoerNaam();
            reeks = InvoerReeks();
            mutsnummer = InvoerMutsnummer();
            speler1.StelIn(naam, mutsnummer, false, true, reeks);

            Waterpolospeler speler2 = new Waterpolospeler();
            Console.WriteLine("\nInstellen speler 2");
            naam = InvoerNaam();
            reeks = InvoerReeks();
            mutsnummer = InvoerMutsnummer();
            speler2.StelIn(naam, mutsnummer, false, true, reeks);

            //speler1.Gooibal();
            //speler2.Gooibal();

            Waterpolospeler testSpeler = new Waterpolospeler();
            //SimuleerSpeler(testSpeler);
            //SimuleerWedstrijd(speler1, speler2);
            Waterpolospeler besteSpeler = BesteSpeler(speler1, speler2);
            Console.WriteLine($"\n{besteSpeler.spelerNaam} uit {besteSpeler.reeks} klasse met mutsnummer {besteSpeler.mutsnummer} wint.");

        }

        private static void SimuleerSpeler(Waterpolospeler testSpeler)
        {
            for (int i = 1; i <= 3; i++)
            {
                testSpeler.Gooibal();

            }
        }

        static void SimuleerWedstrijd(Waterpolospeler speler1, Waterpolospeler speler2)
        {
            //speler1.Gooibal();
            Random r = new Random();
            int winnaar = r.Next(1, 3);
            if (winnaar == 1)
            {
                Console.WriteLine($"\n{speler1.spelerNaam} uit {speler1.reeks} klasse met mutsnummer {speler1.mutsnummer} wint.");
            }
            else
            {
                Console.WriteLine($"\n{speler2.spelerNaam} uit {speler2.reeks} klasse met mutsnummer {speler2.mutsnummer} wint.");
            }
        }
        static Waterpolospeler BesteSpeler(Waterpolospeler speler1, Waterpolospeler speler2)
        {
            speler1.Gooibal();
            Random r = new Random();
            int winnaar = r.Next(1, 3);
            if (winnaar == 1)
            {
                return speler1;
            }
            else
            {
                return speler2;
            }
        }
        private static int InvoerMutsnummer()
        {
            Console.Write("Geef het mutsnummer van de speler: ");
            return int.Parse(Console.ReadLine());
        }

        private static string InvoerReeks()
        {
            Console.Write("Geef de reeks van de speler: ");
            return Console.ReadLine();
        }

        private static string InvoerNaam()
        {
            Console.Write("Geef de naam van de speler: ");
            return Console.ReadLine();
        }
    }
}
