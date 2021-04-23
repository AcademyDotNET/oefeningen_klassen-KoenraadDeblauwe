using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class Patient
    {
        public int aantalUur;
        public int totaalKost;
        public string Naam { get; set; }
        public int AantalUur
        {
            get
            {
                return aantalUur;
            }
            set
            {
                aantalUur = value;
            }
        }

        public virtual void Berekenkost()
        {
            totaalKost = 50 + (AantalUur * 20);
            
        }
    }
}
