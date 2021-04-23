using System;

namespace Digitale_kluis
{
    class Program
    {
        static void Main(string[] args)
        {

            bool controlCode = false;
            int code=0;

            DigitaleKluis kluis1 = new DigitaleKluis(982);
            kluis1.CanShowCode = true;
            if (kluis1.CanShowCode==true)
            {
                do
                {
                    Console.WriteLine("Geef een code in: ");
                    code = int.Parse(Console.ReadLine());
                    controlCode = kluis1.Trycode(code);
                } while (!controlCode);
            }
            else
            {
                Console.WriteLine("Er kan geen code ingelezen worden.");
            }
        }
    }
}
