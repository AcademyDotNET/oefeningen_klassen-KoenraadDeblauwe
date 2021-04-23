using System;
using System.Collections.Generic;
using System.Text;

namespace Sports

    {
    //public enum Reeks { eerste, tweede }
    class Waterpolospeler
    {
        public string spelerNaam;
        public int mutsnummer;
        public string reeks;
        public string SpelerNaam
        {
            get
            {
                return spelerNaam;
            }
            set
            {
                spelerNaam = value;
            }
        }
        
        public bool IsDoelman { get; set; }
        private bool IsReserve { get; set; }
        private string Reeks
        {
            get
            {
                return reeks;
            }
            set
            {
                reeks = value;
            }
        }


        public int Mutsnummer
        {
            get
            {
                return mutsnummer;
            }
            set
            {
                if (mutsnummer >=1 && mutsnummer <= 13)
                {
                    mutsnummer = value;
                }
            }
        }
        public void StelIn(string v1, int v2, bool v3, bool v4, string v5)
        {
            SpelerNaam = v1;
            mutsnummer = v2;
            IsDoelman = v3;
            IsReserve = v4;
            Reeks = v5;

        }

        public void Gooibal()
        {
            Console.WriteLine($"\nIk {SpelerNaam} gooi de bal uit de {Reeks} reeks met het mutsnummer {Mutsnummer}.");
        }

       
    }
}
