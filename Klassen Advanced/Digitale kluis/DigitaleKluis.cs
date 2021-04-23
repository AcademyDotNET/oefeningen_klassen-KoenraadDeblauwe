using System;
using System.Collections.Generic;
using System.Text;

namespace Digitale_kluis
{
    class DigitaleKluis
    {
        private int code;
        public bool canShowCode;
        public int codeLevel;
        private int aantalPogingen = 1;

        public DigitaleKluis(int _code)
        {
            code = _code;
        }

        public bool CanShowCode { get; set; } = false;
        //{
        //    get
        //    {
        //        return canShowCode;
        //    }
        //    set
        //    {
        //        canShowCode = value;
        //    }
        //}
        public int CodeLevel
        {
            get
            {
                return code / 1000;
            }
        }
        public int Code
        {
            get
            {
                if (!CanShowCode)
                {
                    return -666;
                }
                else
                {
                    return code;
                }
            }
            private set
            {
                code = value;
            }
        }

        public bool Trycode(int externeCode)
        {

                if (externeCode == code)
                {
                    Console.WriteLine($"De code is geldig. De gebruiker heeft {aantalPogingen} keer geprobeerd.");
                    return true;
                }
                else if (externeCode == -666)
                {
                    Console.WriteLine("U bent een cheater.");
                    return false;
                }


                else
                {
                    Console.WriteLine("Dit is een foute code.");
                    aantalPogingen++;
                    return false;
                }
            
         }


    }


}
