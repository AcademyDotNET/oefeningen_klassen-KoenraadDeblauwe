using System;
using System.Collections.Generic;

namespace HiddenBookmark
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string url;
            int count = 1;
            int clearNr;
            List < Bookmark > Sites =   new List<Bookmark>();
            HiddenBookmark []site = new HiddenBookmark [3];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Geef uw 3 favoriete sites:\n");
            Console.ResetColor();

            for (int i = 0; i < 3; i++)
            {
                site[i] = MaakBookmark();
            }

            foreach (var item in site)
            {
                Console.WriteLine($"{count}: {item.Naam} {item.URL}");
                count++;
            }

            /*Console.WriteLine("Geef het bookmarknummer dat je wil verwijderen: ");
            clearNr = int.Parse(Console.ReadLine());
            site[clearNr-1].Naam=" ";
            site[clearNr-1].URL = " ";
            count = 0;
            foreach (var item in site)
            {
                Console.WriteLine($"{count}: {item.Naam} {item.URL}");
                count++;
            }*/

            site[0].OpenSite();
        }
        static HiddenBookmark MaakBookmark()
        {
            HiddenBookmark site = new HiddenBookmark();
            string naam, url;
            Console.Write("naam: ");
            naam = Console.ReadLine();
            site.Naam = naam;
            Console.Write("url: ");
            url = Console.ReadLine();
            Console.WriteLine("");
            site.URL = url;
            return site;
        }

        static void VerwijderBookmark(Bookmark site)
        {
            Console.WriteLine("Geef het bookmarknummer dat je wil verwijderen: ");

        }
    }
}
