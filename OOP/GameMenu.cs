using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGameProgram
{
    class GameMenu
    {
        public void numGuessing()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You're running the number guessing program!");
            Random rand = new Random();
            int randNumber = rand.Next(0, 100);
            int guess = 0;
            int i = 3;
            //Console.WriteLine(randNumber);
            while (i > 0)
            {
                Console.WriteLine($"You have {i} guesses remaining.\nPlease guess a number between 1 and 100: ", i);
                guess = int.Parse(Console.ReadLine());
                if (guess == randNumber)
                {
                    Console.WriteLine("You guessed the correct number! Great job!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    break;
                }
                else if (guess > randNumber)
                {
                    Console.WriteLine("Your guess was too high!");
                }
                else if (guess < randNumber)
                {
                    Console.WriteLine("Your guess was too low!");
                }
                i--;
            }
            if (i == 0)
            {
                Console.WriteLine("You have lost the game. Sucks to suck, I'd imagine.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

        }

        public void primeNumber()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please enter a number: ");
            int prime = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int n = 2; n < prime / 2; n++)
            {
                if (prime % n == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Your number is Prime!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your number is not Prime!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }
        public void GetSeason()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to season guesser!\nPlease choose a month:\n1) January\n2) February\n3) March\n4) April\n5) May\n6) June\n7) July\n8) August\n9) September\n10) October\n11) November\n12) December");
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "Septembder", "October", "November", "December" };
            string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
            try
            {
                int monthInYear = int.Parse(Console.ReadLine());
                if (monthInYear < 1 || monthInYear > 12)
                {
                    GetSeason();
                }
                switch (monthInYear)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Season: {0}.", seasons[0]);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Season: {0}.", seasons[1]);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Season: {0}.", seasons[2]);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Season: {0}.", seasons[3]);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                }


            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please enter a valid numeric expression from 1-9\nPress any key to continue");
                Console.ReadKey();
            }
        }

        public void factorialGame()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the factorial game!\nPlease enter a number: ");
            try
            {
                int num = Int32.Parse(Console.ReadLine());
                int factorial(int numToFactor)
                {
                    if (numToFactor == 0) return 1;
                    return numToFactor * factorial(numToFactor - 1);
                }
                int n = factorial(num);
                Console.WriteLine("{0}! = {1}\n", num, n);
                Console.ReadKey();
                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please enter a valid numeric expression from 1-9\nPress any key to continue");
                Console.ReadKey();
            }
        }

        public void rps()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Rock, Paper, Scissors! Choose your move:\n1) Rock\n2) Paper\n3) Scissors");
            try
            {
                string AIChoice = "";
                string userChoice = "";
                userChoice = Console.ReadLine();
                Random random = new Random();
                int randomNumber = random.Next(1, 4);
                switch(randomNumber)
                {
                    case 1:
                        AIChoice = "Rock";
                        Console.WriteLine("AI chooses {0}", AIChoice);

                        if (userChoice == "1")
                        {
                            Console.WriteLine("DRAW!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        else if (userChoice == "2")
                        {
                            Console.WriteLine("You win!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You lose!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        AIChoice = "Paper";
                        Console.WriteLine("AI chooses {0}", AIChoice);

                        if (userChoice == "1")
                        {
                            Console.WriteLine("You lose!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        else if (userChoice == "2")
                        {
                            Console.WriteLine("DRAW!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You win!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        AIChoice = "Scissors";
                        Console.WriteLine("AI chooses {0}", AIChoice);

                        if (userChoice == "1")
                        {
                            Console.WriteLine("You win!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        else if (userChoice == "2")
                        {
                            Console.WriteLine("You lose!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Draw!\n");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please enter a valid numeric expression from 1-9\nPress any key to continue");
                Console.ReadKey();
            }
        }
    }
}
