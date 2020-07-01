using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game
{
    class Player
    {

        
        public static int hp = 200;
        public int Health = 500;
        public int sila = 200;
        public static int  inteligence = 10;
        public int Damage = 100;
        public int Heal = hp + inteligence;
        public int MaxHealth = 10000;
        public int Mana = inteligence * 10;


        // -----------------------------
        public static void SetName()
        {
            Player pl = new Player();
            Console.WriteLine("What's your name Adventurer? ");
            String Name = Console.ReadLine();
            Console.WriteLine("Hello! " + Name);
        }

    }
}
