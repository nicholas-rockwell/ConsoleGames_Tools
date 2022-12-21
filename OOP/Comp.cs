using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGameProgram
{
    class Comp
    {
        public void check()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You're running the number comparison program!");
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Lets compare two numbers. Please provide the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("The larger of the two numbers is: " + num1 + ".\nThanks for playing, " + name + "!");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Nice try, " + name + ". Your two numbers are equal!");
            }
            else
            {
                Console.WriteLine("The larger of the two numbers is: " + num2 + ".\nThanks for playing, " + name + "!");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void evenOdd()
        {
            Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You're running the even or odd program!");
                        Console.WriteLine("What's your name? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Lets determine if your numer is even or odd. Please provide a number: ");
                        double num1 = double.Parse(Console.ReadLine());
                        if ((num1 % 2 == 0) && (num1 / 2 != 0))
                        {
                            Console.WriteLine("Your number is even!\nThanks for playing, " + name + "!");
                        }
                        else if (num1.Equals(0))
                        {
                            Console.WriteLine("Nice try, " + name + ". You'll have to do better than that.");
                        }
                        else
                        {
                            Console.WriteLine("Your number is odd!\nThanks for playing, " + name + "!");
                        }
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
        }
    }
}
