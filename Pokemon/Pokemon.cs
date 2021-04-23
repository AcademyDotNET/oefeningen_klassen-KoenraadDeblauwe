using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class Pokemon
    {
        private int hitpoints;
        private int attack;
        private int defence;
        private int specialAttack;
        private int specialDefence;
        private int speed;
        private int level;

        public string Naam { get; set; }
        public string Type { get; set; }
        public int Nummer { get; set; }

        public double Average
        {
            get
            {
                return (HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base) / 6;
            }
        }
        public int Total
        {
            get
            {
                return HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base;

            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            private set
            {
                level = value;
            }
        }

        public int HP_Base
        {
            get
            {
                return  hitpoints;
            }
            set
            {
                hitpoints = value;
            }
        }

        public int Attack_Base
        {
            get
            {
                return  attack;
            }
            set
            {
                attack = value;
            }
        }

        public int Defence_Base
        {
            get
            {
                return  defence;
            }
            set
            {
                 defence = value;
            }
        }

        public int SpecialAttack_Base
        {
            get
            {
                return  specialAttack;
            }
            set
            {
                specialAttack = value;
            }
        }
        public int SpecialDefence_Base
        {
            get
            {
                return  specialDefence;
            }
            set
            {
                specialDefence = value;
            }
        }
        public int Speed_Base
        {
            get
            {
                return  speed;
            }
            set
            {
                speed = value;
            }
        }

        public double HP_Full
        {
            get
            {
                return (((HP_Base + 50) * Level) / 50) + 10;
            }
        }
        public double Attack_Full
        {
            get
            {
                return ((Attack_Base * Level) / 50) + 5;
            }
        }
        public double Defence_Full
        {
            get
            {
                return ((Defence_Base * Level) / 50) + 5;
            }
        }
        public double SpecialAttack_Full
        {
            get
            {
                return ((SpecialAttack_Base * Level) / 50) + 5;
            }
        }
        public double SpecialDefence_Full
        {
            get
            {
                return ((SpecialDefence_Base * Level) / 50) + 5;
            }
        }
        public double Speed_Full
        {
            get
            {
                return ((Speed_Base * Level) / 50) + 5;
            }
        }
        public void VerhoogLevel()
        {
            Level++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Naam} level {Level}");
            Console.WriteLine("Base stats:");
            Console.WriteLine($"\t* Health = {HP_Base}");
            Console.WriteLine($"\t* Speed =  {Speed_Base}");
            Console.WriteLine($"\n\t* Health = {HP_Full}");
            Console.WriteLine($"\t* Speed = {Speed_Full}");



        }
    }
}
//HP_Base
//Attack_Base
//Defense_Base
//SpecialAttack_Base
//SpecialDefense_Base
//Speed_Base