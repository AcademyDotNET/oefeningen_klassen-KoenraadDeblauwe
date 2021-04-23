using System;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("BankManager\n\n");
            Account klant1 = new Account();
            Account klant2 = new Account();

            klant1.Rekeningnummer = 10;
            
            void GeldAfHalen()
            {
                int rekeningnrr = 0;
                Console.Write("Geef rekeningnr: ");
                rekeningnrr = int.Parse(Console.ReadLine());
                if (rekeningnrr == klant1.Rekeningnummer)
                {
                    klant1.WithdrawFunds();
                }
                else
                {
                    Console.WriteLine("Verkeerd rekeningnr.");
                }
            }

            GeldAfHalen();
            
        }

        
       
    }
}
