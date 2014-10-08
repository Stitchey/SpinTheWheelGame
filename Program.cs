using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinTheWheelGame
{
    class Program
    {

        public static int PlayPoints = 0;
        public static string playerName;
        static int gameNr;
        static string game;
        public static int slowDownI = 0;

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Insert your name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.White;
            playerName = Console.ReadLine();
            Console.Clear();
           
            //Minigame.wheelGame();
            //Minigame.GuessNumber();
            //Minigame.Multiplication();
            //Minigame.FightGame();
            //

            //start

            //Welcome to our game! -Made by Rickard and Erik S.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to our game, {0}!", playerName);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Made by ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Rickard ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("and ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Erik S");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(". ");
            Console.WriteLine();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hit enter to spin the wheel!");
            Console.Read();

            TheWheel();
        }


        public static void TheWheel()
        {

            Console.Clear();
        
            //setting int "game" as different things depending on int number
            //game = 
        

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            System.Threading.Thread.Sleep(slowDownI = 0);

                //wheel spin ( to choose a game)
                for (int i = 0; i <= 69; i++)
                {

                    Random random = new Random();

                    if (i <= 50)
                    {
                        //Slows the text down
                        System.Threading.Thread.Sleep(slowDownI++);

                        gameNr = random.Next(1, 16);

                        Console.WriteLine(game);

                        Console.Clear();

                    }

                    else if (i >= 50 && i <= 60)
                    {
                        System.Threading.Thread.Sleep(slowDownI += 5);

                        gameNr = random.Next(1, 16);
                        Console.WriteLine(game);

                        Console.Clear();
                    }

                    else if (i > 60 && i <= 65)
                    {

                        System.Threading.Thread.Sleep(slowDownI += 10);

                        gameNr = random.Next(1, 16);
                        Console.WriteLine(game);

                        Console.Clear();
                    }

                    else if (i > 65 && i <= 67)
                    {

                        System.Threading.Thread.Sleep(slowDownI += 50);

                        gameNr = random.Next(1, 16);
                        Console.WriteLine(game);

                        Console.Clear();
                    }

                    else if (i > 67 && i < 69)
                    {

                        System.Threading.Thread.Sleep(slowDownI += 99);

                        gameNr = random.Next(1, 16);
                        Console.WriteLine(game);

                        Console.Clear();
                    }

                    else if (i == 69)
                    {

                        System.Threading.Thread.Sleep(slowDownI += 300);

                        gameNr = random.Next(1, 7);
                        Console.WriteLine(game);

                        Console.Clear();
                    }

                    // / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / //

                    Console.WriteLine();


                    //All different games.

                    // Guess the number.
                    if (gameNr == 1)
                    {
                        game = "Guess the number";
                        Console.Write(game);
                        //Minigame;
                    }

                    // Multiplication.
                    if (gameNr == 2)
                    {
                        game = "Multiplication";
                        Console.Write(game);
                    }

                    // Fight.
                    if (gameNr == 3)
                    {
                        game = "Fight";
                        Console.Write(game);
                    }

                    //
                    if (gameNr == 4)
                    {
                        game = "Adventure";
                        Console.Write(game);
                    }

                    //
                    if (gameNr == 5)
                    {
                        game = "The wheel";
                        Console.Write(game);
                    }

                    //
                    if (gameNr == 6)
                    {
                        game = "Yahtzee";
                        Console.Write(game);
                    }

                    //
                    if (gameNr == 7)
                    {
                        game = "OPEOP";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 8)
                    {
                        game = "HGAHGA";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 9)
                    {
                        game = "BANABNBBDANA";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 10)
                    {
                        game = "OAREA";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 11)
                    {
                        game = "OREO";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 12)
                    {
                        game = "!";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 13)
                    {
                        game = "D0OEI";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 14)
                    {
                        game = "ASASASASSSASSASSA";
                        Console.WriteLine(game);
                    }

                    //
                    if (gameNr == 15)
                    {
                        game = "FLIPPERPLIPPER";
                        Console.WriteLine(game);
                    }

                }

                System.Threading.Thread.Sleep(700);

                //game was chosen
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.Write(game);

                //For loop makes it blink! yay!
                for (int i = 0; i <= 3; i++)
                {

                    System.Threading.Thread.Sleep(150);

                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("");

                    System.Threading.Thread.Sleep(150);

                    Console.Clear();
                    Console.WriteLine();
                    Console.Write(game);

                }

                Console.Clear();
                Console.WriteLine();
                Console.Write(game);

                System.Threading.Thread.Sleep(1500);

                //MINIGAME PATHS

                // Guess the number.
                if (gameNr == 1)
                {
                    Minigame.GuessNumber();
                }

                // Multiplication.
                else if (gameNr == 2)
                {
                    Minigame.Multiplication();
                }

                // Fight.
                else if (gameNr == 3)
                {
                    Minigame.FightGame();
                }

                // Multiplication.
                else if (gameNr == 4)
                {
                    Minigame.Adventure();
                }

                // Multiplication.
                else if (gameNr == 5)
                {
                    Minigame.wheelGame();
                }

                // Multiplication.
                else if (gameNr == 6)
                {
                    Minigame.Yahtzee();
                }

                // Multiplication.
                else if (gameNr == 7)
                {

                }

                // Multiplication.
                else if (gameNr == 8)
                {

                }

                // Multiplication.
                else if (gameNr == 9)
                {

                }

                // Multiplication.
                else if (gameNr == 10)
                {

                }

                // Multiplication.
                else if (gameNr == 11)
                {

                }

                // Multiplication.
                else if (gameNr == 12)
                {

                }

                // Multiplication.
                else if (gameNr == 13)
                {

                }

                // Multiplication.
                else if (gameNr == 14)
                {

                }

                // Multiplication.
                else if (gameNr == 15)
                {

                }
            }
        }
    }