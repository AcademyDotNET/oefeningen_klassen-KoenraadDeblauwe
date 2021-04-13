using System;

namespace Studentklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Klas = Klassen.EA2;
            student1.Leeftijd = 21;
            student1.Naam = "Joske Vermeulen";
            student1.PuntenCommunicatie = 12;
            student1.PuntenProgrammingPrinciples = 15;
            student1.PuntenWebTech = 13;
            student1.GeefOverzicht();

            Console.ReadLine();
            Console.Clear();

            Student student2 = new Student();
            student2.Klas = Klassen.EA3;
            student2.Leeftijd = 22;
            student2.Naam = "Koenraad Deblauwe";
            student2.PuntenCommunicatie = 15;
            student2.PuntenProgrammingPrinciples = 17;
            student2.PuntenWebTech = 19;


            student2.GeefOverzicht();
        }
    }
}
