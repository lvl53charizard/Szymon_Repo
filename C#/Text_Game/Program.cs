using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Player pl = new Player();
            Enemy en = new Enemy();
            Random rnd = new Random();
            // ----------------- Story Stuff
            
            Player.SetName();
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            // ----------------- Enemy Stuff
            string MonsterName;
            string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[rnd.Next(s.Length)]).ToArray());
            }
            MonsterName = RandomString(8);

            // --------------------------------- Own monster
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Do You want to Create your own monster?  Yes/No");
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Set Monster's Health!");
                Int32.TryParse(Console.ReadLine(), out en.Health);
                Console.WriteLine("Monster's Health == " + en.Health + "!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Set Monster's Damage!");
                Int32.TryParse(Console.ReadLine(), out en.Damage);
                Console.WriteLine("Monster's Damage == " + en.Damage + "!");
                Console.WriteLine("Set Monster's Heal!");
                Int32.TryParse(Console.ReadLine(), out en.Heal);
                Console.WriteLine("Monster's Heal == " + en.Heal + "!");
            }

            // ----------------- Player Stuff
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Do You want to Set your own Stats?  Yes/No");
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Set Your Health!");
                Int32.TryParse(Console.ReadLine(), out pl.Health);
                Console.WriteLine("Your Health == " + pl.Health + "!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Set Your Damage!");
                Int32.TryParse(Console.ReadLine(), out pl.Damage);
                Console.WriteLine("Your Damage == " + pl.Damage + "!");
                Console.WriteLine("Set Your Heal!");
                Int32.TryParse(Console.ReadLine(), out pl.Heal);
                Console.WriteLine("Your Heal == " + pl.Heal + "!");
            }
            // ----------------- Diff Stuff
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Choose your difficulty!");
            Console.WriteLine("1 = Easy");
            Console.WriteLine("2 = Normal");
            Console.WriteLine("3 = Hard");
            
            int Diff;
            Int32.TryParse(Console.ReadLine(), out Diff);
            switch (Diff)
            {
                case 1:
                    pl.Damage += en.Damage;
                    pl.Health += en.Health;
                    pl.Heal += en.Heal;
                    pl.MaxHealth = pl.Health;
                    break;
                case 2:
                    break;
                case 3:
                    pl.Damage = en.Damage;
                    pl.Health = en.Health;
                    pl.Damage /= 2;
                    pl.Health /= 2;
                    pl.Heal *= 20;
                    pl.MaxHealth /= 2;
                    break;
                default:
                    break;
            }

            // ----------------- Story Stuff
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You have encountered an enemy Called " + MonsterName + "!");
                Console.WriteLine("Enemy has " + en.Health + " Health!");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Your attack = " + pl.Damage);
                Console.WriteLine("Your Health = " + pl.Health);
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("If you want to attack press 1");
                Console.WriteLine("If you want to heal press 2");
                Console.WriteLine("If you want to use magic attack press 3 (Consumes 50 Mana!)");

            // -------------------- Engine xD


            while (pl.Health >= 0 || en.Health <= 0)
            {

                // ----------------- Combat Stuff
                int Action = 1;
                Int32.TryParse(Console.ReadLine(), out Action);
                switch (Action)
                {
                    
                    // ---------------- Normal Attack
                    case 1:
                        a:
                        System.Threading.Thread.Sleep(150);
                        Console.WriteLine("You have attacked!");
                        en.Health -= pl.Damage;
                        Console.WriteLine("Enemy health = " + en.Health);
                        pl.Mana += 10;
                        Console.WriteLine("Your Mana = " + pl.Mana);
                        break;

                    // ---------------- Heal
                    case 2:
                        Console.WriteLine("You have Healed!");
                        System.Threading.Thread.Sleep(150);
                        if (pl.Health < pl.MaxHealth)
                        {
                            pl.Health += pl.Heal;
                            // --------------- Check if player has to much health
                            if (pl.Health > pl.MaxHealth)
                            {
                                pl.Health = pl.MaxHealth;
                            }
                        }
                        Console.WriteLine("Your health = " + pl.Health);
                        break;

                    // --------------------- Magic ATtack
                    case 3:
                        if (pl.Mana >= 50)
                        {
                            Console.WriteLine("Magic Attack!");
                            en.Health /= 2;
                            Console.WriteLine("Enemy health = " + en.Health);
                            pl.Mana -= 50;
                            Console.WriteLine("Your Mana = " + pl.Mana);
                        }
                        else
                        {
                            
                            Console.WriteLine("Not enough mana!");
                            System.Threading.Thread.Sleep(150);
                            goto a;
                        }
                        
                        break;
                    // ------------------------ Default
                    default:
                        Console.WriteLine("You did nothing!");
                        Console.WriteLine("Your health = " + pl.Health);
                        pl.Mana += 10;
                        Console.WriteLine("Your Mana = " + pl.Mana);
                        System.Threading.Thread.Sleep(150);
                        
                        break;
                }
                // ----------------------------- Ai Stuff

                    int poly = rnd.Next(0, 10);
                    if (poly >= 4)
                    {
                        pl.Health -= en.Damage;
                        Console.WriteLine("Enemy Attacked! Your health is now = " + pl.Health);
                        if (poly >= 7)
                        {
                            en.Health += en.Heal;
                        }
                    }
                // ----------------------------- Story.Ending
                if (pl.Health <= 0)
                {
                    Console.WriteLine("You lost!");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                if (en.Health <= 0)
                {
                    Console.WriteLine("You win!");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }

            }
               

        }
    }
}
