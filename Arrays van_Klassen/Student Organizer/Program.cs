using System;
using System.Collections.Generic;

namespace Student_Organizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int keuze=1;
            // Bevolken van de list
            List<Student> Student = new List<Student>();
            for (int i = 1; i <= 5; i++)
            {
                Student student = new Student();
                Student.Add(student);
            }

            // Controle van de defaultwaarden van de studenten list
            //foreach (var item in Student)
            //{
            //    Console.WriteLine($"{item.Naam} {item.Klas} {item.Leeftijd} {item.PuntenCommunicatie} {item.PuntenProgrammingPrinciples} {item.PuntenWebTech}");
            //}

            // Menu keuze
            int menuKeuze=0;
            int keuzeMenuTwee = 1;
            
            while (menuKeuze != 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Menu keuze:");
                Console.ResetColor();
                Console.WriteLine("1: gegenvens invoeren");
                Console.WriteLine("2. gegevens tonen");
                Console.WriteLine("3. stoppen");
                Console.ForegroundColor = ConsoleColor.Black;
                menuKeuze = int.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();
                switch (menuKeuze)
                {
                    case 1:
                        {
                            // Invullen lijst
                            do
                            {

                                Console.Write("\nGeef een studentnr in van 1 tot 5: ");
                                keuze = int.Parse(Console.ReadLine());
                                if (keuze != 0)
                                {
                                    keuze--;
                                    Console.Write("\nNaam: ");
                                    Student[keuze].Naam = Console.ReadLine();
                                    Console.Write($"Klas van {Student[keuze].Naam}: ");

                                    Klassen Klasinput;
                                    while (!Klassen.TryParse(Console.ReadLine().ToUpper(), out Klasinput))
                                    {
                                        Console.WriteLine("Geef een juiste klas in!");
                                    }
                                    Student[keuze].Klas = Klasinput;

                                    Console.Write("Leeftijd: ");
                                    Student[keuze].Leeftijd = int.Parse(Console.ReadLine());
                                    Console.Write("PuntenCommunicatie: ");
                                    Student[keuze].PuntenCommunicatie = int.Parse(Console.ReadLine());
                                    Console.Write("PuntenProgrammingPrinciples: ");
                                    Student[keuze].PuntenProgrammingPrinciples = int.Parse(Console.ReadLine());
                                    Console.Write("PuntenWebTech: ");
                                    Student[keuze].PuntenWebTech = int.Parse(Console.ReadLine());
                                    keuze++;
                                }
                                Console.Clear();
                                Console.Write("Wil je nog een student invoeren?");
                                Console.Write("\n\n0. neen\n1. ja");
                                keuzeMenuTwee = int.Parse(Console.ReadLine());
                                
                                Console.Clear();
                            } while (keuzeMenuTwee != 0);
                            break;
                        }
                    case 2:
                        {
                            foreach (var item in Student)
                            {
                                Console.WriteLine($"{item.Naam} {item.Klas} {item.Leeftijd} {item.PuntenCommunicatie} {item.PuntenProgrammingPrinciples} {item.PuntenWebTech}");
                            }
                            Console.ReadLine();

                            break;
                        }
                }
            }

            /*
            // Invullen van de lijst
            do
            {
                Console.Write("\nGeef een studentnr in van 1 tot 5 (0=stop): ");
                keuze = int.Parse(Console.ReadLine());
                if (keuze != 0)
                {
                    keuze--;
                    Console.Write("\nNaam: ");
                    Student[keuze].Naam = Console.ReadLine();
                    Console.Write($"Klas van {student[keuze].Naam}: ");
                                        
                    Klassen Klasinput;
                    while(!Klassen.TryParse(Console.ReadLine().ToUpper(), out Klasinput))
                    {
                        Console.WriteLine("Geef een juiste klas in!");
                    }
                    Student[keuze].Klas = Klasinput;
                    
                    Console.Write("Leeftijd: ");
                    student[keuze].Leeftijd = int.Parse(Console.ReadLine());
                    Console.Write("PuntenCommunicatie: ");
                    Student[keuze].PuntenCommunicatie = int.Parse(Console.ReadLine());
                    Console.Write("PuntenProgrammingPrinciples: ");
                    Student[keuze].PuntenProgrammingPrinciples = int.Parse(Console.ReadLine());
                    Console.Write("PuntenWebTech: ");
                    Student[keuze].PuntenWebTech = int.Parse(Console.ReadLine());
                }
            } while (keuze != 0);

            // Afdrukken van de nieuwe lijst
            foreach (var item in Student)
            {
                Console.WriteLine($"{item.Naam} {item.Klas} {item.Leeftijd} {item.PuntenCommunicatie} {item.PuntenProgrammingPrinciples} {item.PuntenWebTech}");
            } */
            
        }
    }
}
