using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Patient patient1 = new Patient();
            VerzekerdePatient verzekerdePatient1 = new VerzekerdePatient();
            patient1.Naam = "Koenraad";
            patient1.AantalUur = 5;
            patient1.Berekenkost();
            verzekerdePatient1.Naam = "Jesse";
            verzekerdePatient1.AantalUur = 5;
            verzekerdePatient1.Berekenkost();
            Console.WriteLine($"patient:  {patient1.Naam} was {patient1.AantalUur} uur aanwezig en heeft een totaalkost van: {patient1.totaalKost} euro.");
            Console.WriteLine($"patient:  {verzekerdePatient1.Naam} was {verzekerdePatient1.AantalUur} uur aanwezig en heeft een totaalkost van: {verzekerdePatient1.verzekerdePatientKost} euro.");
        }
    }
}
