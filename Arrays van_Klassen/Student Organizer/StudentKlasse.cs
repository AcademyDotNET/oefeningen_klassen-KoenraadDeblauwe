using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Organizer
{
    
        enum Klassen { EA1, EA2, EA3, EA4 }

        class Student
        {
            public  string Naam { get; set; } = "no name";
            public  int Leeftijd { get; set; } = 0;
            public  Klassen Klas { get; set; } = (Klassen)0;

            public  int PuntenCommunicatie { get; set; } = 0;
            public  int PuntenProgrammingPrinciples { get; set; } = 0;
            public  int PuntenWebTech { get; set; } = 0;

            public  double BerekenTotaalCijfer()
            {
                return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
            }

            public  void GeefOverzicht()
            {
                Console.WriteLine($"{Naam}, {Leeftijd} jaar");
                Console.WriteLine($"Klas: {Klas}");
                Console.WriteLine();
                Console.WriteLine("Cijferrapport");
                Console.WriteLine("*************");
                Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
                Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
                Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
                Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():0.0}");
            }
        }
    
}
