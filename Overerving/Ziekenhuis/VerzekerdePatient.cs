using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class VerzekerdePatient:Patient
    {
        
        public double verzekerdePatientKost;
        
        public override void Berekenkost()
        {
            base.Berekenkost();
            verzekerdePatientKost = totaalKost * 0.90;
        }
    }
}
