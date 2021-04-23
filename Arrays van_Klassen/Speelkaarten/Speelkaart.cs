using System;
using System.Collections.Generic;
using System.Text;

namespace Speelkaarten
{
    public enum kleur { Schoppen=1, Harten, Klaveren, Ruiten };
    public class Speelkaart
    {
        public int Getal { get; set; }
        public kleur Suite { get; set; }
    }
}
