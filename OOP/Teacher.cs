using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGameProgram
{
    class Teacher
    {
        public void multiply()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            double result1;
            Console.WriteLine("You're running the multiplication program!");
            Console.WriteLine("Let's multiply two values! Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your second number? ");
            double num2 = double.Parse(Console.ReadLine());
            if (num1.Equals(0) || num2.Equals(0))
            {
                Console.WriteLine("If you take anything times 0, you'll get 0. Silly Goose.");
            }
            else
            {
                result1 = num1 * num2;
                Console.WriteLine(num1 + " times " + num2 + " equals: " + result1 + "!\nThanks for playing!");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void division()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You're running program ");
            Console.WriteLine("What's your name? ");
            string name  = Console.ReadLine();
            Console.WriteLine("Lets divide two numbers. Please provide the number to be divided: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the number to divide by: ");
            double num2 = double.Parse(Console.ReadLine());
            if (num2.Equals(0))
            {
                Console.WriteLine(name + ", you know you can't divide by zero. Silly Goose.");
            }
            else
            {
                double result1 = num1 / num2;
                Console.WriteLine(num1 + " divided by " + num2 + " is equal to: " + result1 + "\nThanks for playing!");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
