using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpinTheWheelGame
{
    class Minigame
    {
                public static string perkType;  

         // Guess The Number  (1)
         public static void GuessNumber()
        {

            int numberU = 1;
            int tryCount = 0;

            Random random = new Random();
            int numberC = random.Next(1, 11);

            while (numberC != numberU)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a number from ");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("1 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("to ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("10 ");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;

                numberU = Convert.ToInt32(Console.ReadLine());

                if (numberU < numberC)
                {
                    Console.WriteLine();
                    Console.WriteLine("Too Low!");
                    Console.WriteLine("Try Again!");
                    System.Threading.Thread.Sleep(1000);
                }

                else if (numberU > numberC)
                {
                    Console.WriteLine();
                    Console.WriteLine("Too High!");
                    Console.WriteLine("Try Again!");
                    System.Threading.Thread.Sleep(1000);
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine(numberC + "!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("It took you ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    tryCount++;
                    Console.Write(tryCount);
                    Console.ForegroundColor = ConsoleColor.White;

                    if (tryCount == 1)
                    {
                        Console.Write(" Try! Good guess!");
                        System.Threading.Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +1");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("p Extra! ");
                        System.Threading.Thread.Sleep(500);
                    }

                    else
                        Console.Write(" Tries.");

                    System.Threading.Thread.Sleep(1000);
                    Minigame.Win();
                }
                tryCount++;
            }
        }

         // Multiplication    (2)
         public static void Multiplication()
        {
            int nr1;
            int nr2;
            int answer;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Random random = new Random();
            nr1 = random.Next(1, 11);
            nr2 = random.Next(1, 11);

            Console.WriteLine("{0} x {1} = ? ", nr1, nr2);
            Console.Read();

            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == nr1 * nr2)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Correct! ");

                Minigame.Win();
            }

            else
                Minigame.Lose();
        }

         // Fight             (3)
         public static void FightGame()
        {
            int mobHp = 100;
            int mobDmg = 0;
            int playerHp = 100;
            int playerDmg = 0;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have to kill this bastard {0}", Program.playerName);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(Program.slowDownI += 100);
                Console.Write("DU dudU du");
            }

            while (true)
            {
                //This block of code shows the statics of the battle
                Console.Clear();
                Console.WriteLine("~~~~~BATTLE~~~~~");
                Console.WriteLine();
                Console.WriteLine("The Magician's Health {0}", mobHp);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0}'s Health {1}", Program.playerName, playerHp);
                Console.WriteLine();
                Console.WriteLine();
                System.Threading.Thread.Sleep(2500);
                Console.Clear();


                Random randomSpell = new Random();
                int magicSpell = randomSpell.Next(1, 5);

                Console.WriteLine("~~~~~BATTLE~~~~~");
                Console.WriteLine();
                Console.WriteLine("The Magician's Health {0}", mobHp);
                Console.WriteLine(magicSpell);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0}'s Health {1}", Program.playerName, playerHp);
                Console.WriteLine();
                Console.WriteLine();
                if (magicSpell == 1)
                {
                    Console.WriteLine();
                    Console.Write("The Magician used 'Fire Bolt'");
                    Random spell1 = new Random();
                    mobDmg = spell1.Next(15, 31);
                    
                    if (mobDmg > 23 && mobDmg < 31)
                    {
                        mobDmg = 60;
                        Console.WriteLine();
                        Console.Write("ITS A CRITICAL HIT");
                    }
                    Console.WriteLine(" {0} Damage", mobDmg);
                    playerHp = playerHp - mobDmg;
                }
                
                else if (magicSpell == 2)
                {
                    Console.WriteLine();
                    Console.Write("The Magician used 'Earth Quake'");
                    Random spell2 = new Random();
                    mobDmg = spell2.Next(25, 35);

                    Console.WriteLine(" ({0}) Damage!", mobDmg);
                    playerHp = playerHp - mobDmg;
                }

                else if (magicSpell == 3)
                {
                    Console.WriteLine();
                    Console.Write("The Magician used 'Self Heal'");
                    mobHp = mobHp + 50;
                    if (mobHp > 100)
                        mobHp = 100;
                }

                else if (magicSpell == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("The Magician used 'Mimmic'");
                    Console.WriteLine("and did the same damage as you did {0}", playerDmg);
                    playerHp = playerHp - playerDmg;
                }
                System.Threading.Thread.Sleep(2500);

                if (playerHp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You Died vs The Magician!");
                    System.Threading.Thread.Sleep(2500);
                    Lose();

                }

                Console.Clear();
                Console.WriteLine("~~~~~BATTLE~~~~~");
                Console.WriteLine();
                Console.WriteLine("The Magician's Health {0}", mobHp);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0}'s Health {1}", Program.playerName, playerHp);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-Choose Attack-");
                Console.WriteLine("[Stab]-[Slash]");
                Console.WriteLine("[Heal]-[Kick]");
                Console.WriteLine("''Type spell below''");
                string attack = Console.ReadLine().ToLower();

                if (attack == "stab")
                {
                    Random pSpell1 = new Random();
                    playerDmg = pSpell1.Next(12, 35);
                    Console.WriteLine();
                    Console.WriteLine("You used 'Stab' ({0}) Damage!", playerDmg);
                    mobHp = mobHp - playerDmg;
                }

                else if (attack == "slash")
                {
                    Random pSpell2 = new Random();
                    playerDmg = pSpell2.Next(17, 23);
                    Console.WriteLine();
                    Console.WriteLine("You used 'Slash' ({0}) Damage!", playerDmg);
                    mobHp = mobHp - playerDmg;
                }

                else if (attack == "heal")
                {
                    Random pSpell3 = new Random();
                    int pHeal = pSpell3.Next(35, 50);
                    Console.WriteLine();
                    Console.WriteLine("You used 'Heal' ({0}) Healed!", pHeal);
                    playerHp = playerHp + pHeal;
                    if (playerHp > 100)
                        playerHp = 100;
                }

                else if (attack == "kick")
                {
                    Random pSpell4 = new Random();
                    playerDmg = pSpell4.Next(5, 15);
                    Console.WriteLine();
                    Console.WriteLine("You used 'Kick' ({0}) Damage!", playerDmg);
                    mobHp = mobHp - playerDmg;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your attack missed!");
                }

                if (mobHp <=0)
                {
                    Console.Clear();
                    Console.WriteLine("You killed The Magician!");
                    System.Threading.Thread.Sleep(2500);
                    Win();

                }
                System.Threading.Thread.Sleep(2500);

            }
        }

         // Adventure         (4)
         public static void Adventure()
         {
             Program.TheWheel();
         }

         // WheelGame         (5)
         public static void wheelGame()
         {
             int perkNr = 0;

             Console.Clear();

             System.Threading.Thread.Sleep(Program.slowDownI = 0);

             //wheel spin (to choose a game)
             for (int i = 0; i <= 69; i++)
             {

                 Random random = new Random();

                 if (i <= 50)
                 {
                     //Slows the text down
                     System.Threading.Thread.Sleep(Program.slowDownI++);

                     perkNr = random.Next(1, 11);

                     //Console.Clear();

                 }

                 else if (i >= 50 && i <= 60)
                 {
                     System.Threading.Thread.Sleep(Program.slowDownI += 5);

                     perkNr = random.Next(1, 11);

                     //Console.Clear();
                 }

                 else if (i > 60 && i <= 65)
                 {

                     System.Threading.Thread.Sleep(Program.slowDownI += 10);

                     perkNr = random.Next(1, 11);

                     //Console.Clear();
                 }

                 else if (i > 65 && i <= 67)
                 {

                     System.Threading.Thread.Sleep(Program.slowDownI += 50);

                     perkNr = random.Next(1, 11);

                     //Console.Clear();
                 }

                 else if (i > 67 && i < 69)
                 {

                     System.Threading.Thread.Sleep(Program.slowDownI += 99);

                     perkNr = random.Next(1, 11);

                     //Console.Clear();
                 }

                 else if (i == 69)
                 {

                     System.Threading.Thread.Sleep(Program.slowDownI += 300);

                     perkNr = random.Next(1, 11);

                     Console.WriteLine();
                     //Console.Clear();
                 }

                 if (perkNr == 1 || perkNr == 2 || perkNr == 3 || perkNr == 4 || perkNr == 5)
                 {
                     Console.ForegroundColor = ConsoleColor.Green;
                     perkType = "+1 point!";
                     Console.WriteLine(perkType);
                     //Minigame;

                     Program.PlayPoints++;
                 }

                 //
                 if (perkNr == 6 || perkNr == 7)
                 {
                     Console.ForegroundColor = ConsoleColor.Magenta;
                     perkType = "+2 points!";
                     Console.WriteLine(perkType);

                     Program.PlayPoints+= 2;
                 }

                 if (perkNr == 8)
                 {
                     Console.ForegroundColor = ConsoleColor.Yellow;
                     perkType = "+3 points!";
                     Console.WriteLine(perkType);

                     Program.PlayPoints+= 3;
                 }

                 if (perkNr == 9 || perkNr == 10)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     perkType = "-1 Point!";
                     Console.WriteLine(perkType);

                     Program.PlayPoints--;
                 }
             }

             System.Threading.Thread.Sleep(1000);

             for (int j = 0; j <= 3; j++)
             {

                 Console.Clear();

                 System.Threading.Thread.Sleep(150);

                 Console.Write(perkType);

                 System.Threading.Thread.Sleep(150);
             }

             System.Threading.Thread.Sleep(350);

             Console.Clear();
             Program.TheWheel();

         }

         // Yahtzee           (6)
         public static void Yahtzee()
         {
             int dice1 = 0;
             int dice2 = 0;
             int dice3 = 0;
             int dice4 = 0;
             int dice5 = 0;
             string yahtzee = "Yahtzee";
             string four_of_a_kind = "Four of a kind";
             string full_house = "Full house";
             string straight = "Straight";
             string three_of_a_kind = "Three of a kind";
             string two_pair = "Two pair";
             string pair = "Pair";
             string chance = "Chance";

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.WriteLine("Press [Enter] to roll the dice");
             Console.ReadLine();

             Random randomDice = new Random();
             dice1 = randomDice.Next(1, 7);
             dice2 = randomDice.Next(1, 7);
             dice3 = randomDice.Next(1, 7);
             dice4 = randomDice.Next(1, 7);
             dice5 = randomDice.Next(1, 7);

             Console.Clear();
             Console.Write("You got: ");
             Console.Write("{0} ", dice1);
             Console.Write("{0} ", dice2);
             Console.Write("{0} ", dice3);
             Console.Write("{0} ", dice4);
             Console.WriteLine("{0} ", dice5);
             Console.WriteLine();

             Console.WriteLine("Your combinations is..");
             Console.WriteLine("v v v v v v v v v v v v");
             Console.WriteLine();
             Console.WriteLine("Chance = {0}", dice1 + dice2 + dice3 + dice4 + dice5);

             Console.ReadLine();
         }





         // +playPoint and SPIN AGAIN
         public static void Win()
         {

             System.Threading.Thread.Sleep(1000);
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine();
             Console.Write("Great! ");
             System.Threading.Thread.Sleep(1000);
             Console.ForegroundColor = ConsoleColor.Green;
             Console.Write(" +1");
             Console.ForegroundColor = ConsoleColor.White;
             Console.Write("p ");
             System.Threading.Thread.Sleep(1000);

             Program.PlayPoints++;

             Console.Clear();

             Program.TheWheel();
         }

         // -playPoint and SPIN AGAIN
         public static void Lose()
         {
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine();
             Console.Write("Miss! ");
             System.Threading.Thread.Sleep(1000);
             Console.ForegroundColor = ConsoleColor.Red;
             Console.Write(" -1");
             Console.ForegroundColor = ConsoleColor.White;
             Console.Write("p ");
             System.Threading.Thread.Sleep(1500);

             Program.PlayPoints--;

             Console.Clear();

             Program.TheWheel();

         }
    }
}
