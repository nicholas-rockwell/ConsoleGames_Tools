using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGameProgram
{
    class Calculator
    {
        public void salaryCalculations()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You're running the employee wage calculator!");
            double hrWage;
            double hrWeek;
            double result;
            Console.WriteLine("\nWhat is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your hourly rate of pay? ");
            hrWage = double.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week? ");
            hrWeek = double.Parse(Console.ReadLine());
            result = (((hrWage * hrWeek) * 4) * 12);
            Console.WriteLine(name + "'s salary is: $" + result + " dollars per year.");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void gpaCalculations()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            double sGPA;
            double pGPA = 2.50;
            Console.WriteLine("You're running program gpa calculation program!");
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What's your current gpa? ");
            sGPA = double.Parse(Console.ReadLine());
            if (sGPA >= pGPA)
            {
                Console.WriteLine("Congratulations " + name + ", you're passing!");
            }
            else
            {
                Console.WriteLine(name + ", you're currently failing your classes, clean it up.");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void cubeNumber()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the cubic root \"Game\". Please enter a number to cube:\n ");
            double x = Double.Parse(Console.ReadLine());

            double num1 = Math.Cbrt(x);
            Console.WriteLine("Cube root of " + x + ": " + num1);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void averageOfInts()
        {
            List<int> list11 = new List<int>();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the average \"Game\". How many numbers would you like to input(2-30)? :\n ");
            int numOfInts = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numOfInts; i++)
            {
                Console.WriteLine("Okay, please enter a number: ");
                int y = Int32.Parse(Console.ReadLine());
                list11.Add(y);
            }
            int total = list11.Sum(x => Convert.ToInt32(x));
            int result = total / numOfInts;
            Console.WriteLine("Your average is: " + result);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void multiplicationTable()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the multiplication \"Game\". Please enter a number to multiply:\n ");
            int num1 = Int32.Parse(Console.ReadLine());


            for (int multiplier = 1; multiplier <= 20; multiplier++)
                {
                    Console.WriteLine("{0} * {1} = {2}", num1, multiplier, (num1 * multiplier));
                }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void ifAlphabetical()
        {
            Console.WriteLine("Please give me letters to see if they are alphabetical");
            string input = Console.ReadLine();
            input = input.ToLower();
            char[] arr = (input).ToCharArray();
            int[] number = new int[arr.Length];
            bool flagAlph = true;
            for (int i = 0; i < arr.Length; ++i)
            {
                number[i] = (int)arr[i] % 32;
            }
            for (int i = 0; i < (number.Length - 1); ++i)
            {
                //Console.WriteLine("" + number[i]);
                if (number[i] != (number[i + 1] - 1))
                {
                    flagAlph = false;
                }
            }
            if (!flagAlph)
            {
                Console.WriteLine("your input was not in alphabetical order.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("your input was in alphabetical order.");
            Console.ReadKey();
        }
    }
}
