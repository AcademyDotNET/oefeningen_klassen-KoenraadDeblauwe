using System;
using System.Collections.Generic;
using System.Text;

namespace Studentklasse
{
    public enum Klassen { EA2, EA3 }
    class Student
    {
        
        
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

  

    
        public double BerekenTotaalcijfer()
        {
            return (((double)PuntenCommunicatie + (double)PuntenProgrammingPrinciples + (double)PuntenWebTech)) / 3;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}\n\n");
            Console.WriteLine("Cijferrapport:");
            Console.WriteLine("**************");
            Console.WriteLine($"Communicatie:\t\t {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
            Console.WriteLine($"Gemiddelde:\t\t {BerekenTotaalcijfer():F1}");
        }
    }
}
