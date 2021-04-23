using System;
using System.Collections.Generic;
using System.Text;

namespace Het_dierenrijk
{
    class Animal
    {
        public static string BeweegVoort { get; set; } = "traag";

     public virtual void ToonInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Het dier beweegt {BeweegVoort} ");
            Console.ResetColor();
        }
    }
}
