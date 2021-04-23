
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
{
    class Account
    {
        public string Naamveld { get; set; }
        int balans = 100;
        private int Balans { get; set; } = 100;
        public int Bedrag { get; set; }
        public int Rekeningnummer { get; set; }
        private int geldOpRekening;
        private int bedrag = 0;
        private int bedrag2 = 0;

        public void WithdrawFunds()
        {
            
            GetBalance();
            Console.Write("Geef het af te halen bedrag in: ");
            bedrag= int.Parse(Console.ReadLine());
            if(Balans < bedrag)
            {
                bedrag = Bedrag - Balans;
                Balans = 0;
                Bedrag = Bedrag - bedrag;
                Console.WriteLine($"Er stond niet genoeg geld op de rekening, er wordt u {Bedrag} uitbetaald.");
            }
            GetBalance();
        }

        public void GetBalance()
        {

            Console.WriteLine($"De balans van de rekenining is: {Balans}");
        }

        public void PayInFunds()
        {
            Console.Write("Geef het te storten bedrag in: ");
            bedrag = int.Parse(Console.ReadLine());
            balans += bedrag;
            GetBalance();
        }
    }
}
