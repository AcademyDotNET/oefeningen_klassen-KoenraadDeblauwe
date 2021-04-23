using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon ratata = new Pokemon();
            Pokemon metapod = new Pokemon();
            Pokemon kakuna = new Pokemon();
                        
            ratata.HP_Base = 30;
            ratata.Attack_Base = 56;
            ratata.Defence_Base = 35;
            ratata.SpecialAttack_Base = 25;
            ratata.SpecialDefence_Base = 35;
            ratata.Speed_Base = 72;

            metapod.HP_Base = 50;
            metapod.Attack_Base = 20;
            metapod.Defence_Base = 55;
            metapod.SpecialAttack_Base = 25;
            metapod.SpecialDefence_Base = 25;
            metapod.Speed_Base = 30;

            kakuna.HP_Base = 45;
            kakuna.Attack_Base = 25;
            kakuna.Defence_Base = 50;
            kakuna.SpecialAttack_Base = 25;
            kakuna.SpecialDefence_Base = 25;
            kakuna.Speed_Base = 35;

            Console.WriteLine(ratata.Average);
            Console.WriteLine(metapod.Average);
            Console.WriteLine(kakuna.Average);
            Console.WriteLine(ratata.Total);
            Console.WriteLine(metapod.Total);
            Console.WriteLine(kakuna.Total);

            for (int i =1; i<=10; i++)
            {
                ratata.VerhoogLevel();
                Console.WriteLine(ratata.Level);
            }

            Console.WriteLine(ratata.HP_Base);
            Console.WriteLine(ratata.HP_Full);
            Console.WriteLine(metapod.HP_Base);
            Console.WriteLine(metapod.HP_Full);
            Console.WriteLine(kakuna.HP_Base);
            Console.WriteLine(kakuna.HP_Full);
            Console.WriteLine(ratata.Attack_Base);
            Console.WriteLine(ratata.Attack_Full);
            Console.WriteLine(metapod.Attack_Base);
            Console.WriteLine(metapod.Attack_Full);
            Console.WriteLine(kakuna.Attack_Base);
            Console.WriteLine(kakuna.Attack_Full);

            ratata.ShowInfo();
        }
    }
}
