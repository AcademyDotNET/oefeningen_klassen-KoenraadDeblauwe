using System;
using System.Collections.Generic;
using System.Text;

namespace Het_dierenrijk
{
    class Dog:Animal
    {
        public int AantalPoten { get; set; } = 4;

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"en dit op {AantalPoten} poten. ");
            Console.ResetColor();
            
        }
        
    }
}
