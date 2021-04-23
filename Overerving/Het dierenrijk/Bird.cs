using System;
using System.Collections.Generic;
using System.Text;

namespace Het_dierenrijk
{
    class Bird:Animal
    {
        public string Name { get; set; } = "Raaf";
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" want de vogel is een {Name}.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
