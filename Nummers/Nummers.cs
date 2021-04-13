using System;
using System.Collections.Generic;
using System.Text;

namespace Nummers
{
    class Nummers
    {
        private int getal2;
        public double Getal1 { get; set; }
        public int Getal2
        {
            get
            {
                return getal2;
            }
            set
            {
                if (value > 0)
                {
                    getal2 = value;
                }
            }
        }

        

        public double Som()
        {
           return Getal1 + Getal2;
        }
        public double Verschil()
        {
            return Getal1 - Getal2;
        }
        public double Product()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            
            
                return Getal1 / Getal2;
            
        }
    }
}
