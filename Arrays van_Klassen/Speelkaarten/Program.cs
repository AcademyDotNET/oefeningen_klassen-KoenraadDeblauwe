using System;
using System.Collections.Generic;

namespace Speelkaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Speelkaart> alleGetallenSpeelkaarten = new List<Speelkaart>();
            List<Speelkaart> speelkaarten = MaakKaartendek(alleGetallenSpeelkaarten);
            speelkaarten = TrekEenKaart(speelkaarten);
            foreach (var item in speelkaarten)
            {


                Console.WriteLine($"{item.Getal}  {item.Suite}");

            }
        }

        public static List<Speelkaart> MaakKaartendek(List<Speelkaart> v1)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Speelkaart kaart = new Speelkaart();
                    kaart.Getal = j;
                    kaart.Suite = (kleur)i;
                    v1.Add(kaart);
                }
            }
            return v1;
        }

        public static List<Speelkaart> TrekEenKaart(List<Speelkaart> v1)
        {
            int kaartNr;
            Random randomKaart = new Random();
            kaartNr = randomKaart.Next(1, 53);
            
            
            Console.WriteLine($"kaart: {v1[kaartNr].Getal} {v1[kaartNr].Suite}\n");
            v1.RemoveAt(kaartNr);
            return v1;
               
        }



    }
}
