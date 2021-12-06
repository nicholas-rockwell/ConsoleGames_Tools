using System;
using System.Linq;

namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please choose your program:\n1) Calculate Income\n" +
                    "2) Student GPA Check\n3) Multiply Values\n4)" +
                    " Divide Two numbers\n5) Compare Two numbers\n6) Even or Odd\n7) Game Menu\n8) Cubic root game\n9) Display Multiplication Table\n10) Average some numbers\n11) Is it alphabatized\n12) Exit\n");

                int option = int.Parse(Console.ReadLine());
                Calculator calc = new Calculator();
                Teacher teach = new Teacher();
                Comp comp = new Comp();
                GameMenu game = new GameMenu();

                switch (option)
                {

                    case 1:
                        calc.salaryCalculations();
                        break;

                    case 2:
                        calc.gpaCalculations();
                        break;

                    case 3:
                        teach.multiply();
                        break;

                    case 4:
                        teach.division();
                        break;

                    case 5:
                        comp.check();
                        break;

                    case 6:
                        comp.evenOdd();
                        break;

                    case 7:                             // THROW ALL THIS SHIT INTO NEW CLASS "EXTRA STUFF"
                        bool submenu = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Choose an option:\n1) Guess the number\n2) It it prime?\n3) Factorial Game\n4) Season Guessing\n5) Rock, Paper, Scissors\n6) Go Back");
                            int option2 = int.Parse(Console.ReadLine());

                            switch (option2)
                            {

                                case 1:
                                    game.numGuessing();
                                    break;


                                case 2:
                                    game.primeNumber();
                                    break;


                                case 3:
                                    game.factorialGame();
                                    break;

                                case 4:
                                    game.GetSeason();
                                    break;

                                case 5:
                                    game.rps();
                                    break;

                                case 6:
                                    Console.WriteLine("You've chosen to leave the game menu, bye!");
                                    submenu = false;
                                    Console.WriteLine("\nPress any key to Exit");
                                    Console.ReadKey();
                                    break;

                            }
                        } while (submenu == true);
                        break;


                    // Is it a prime number? (say a number, computer outputs if prime number)
                    // one last exercise after this
                    case 8:
                        calc.cubeNumber();
                        break;

                    case 9:
                        calc.multiplicationTable();
                        break;

                    case 10:
                        calc.averageOfInts();
                        break;

                    case 11:
                        calc.ifAlphabetical();
                        break;

                    case 12:
                        Console.WriteLine("You've chosen to exit, take it easy!");
                        flag = false;
                        Console.WriteLine("\nPress any key to Exit");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("The program you've selected doesn't exist.");
                        break;
                }

            } while (flag);
        }

//         Console.WriteLine("Welcome to our art project!\nPlease enter an odd number: ");
//        int num1 = Int32.Parse(Console.ReadLine());
//        string lineSpace = " ";


//for (int i = 0; i <= num1; i++)
//{
//    lineSpace += " ";
//    for (int i = 0; i <= num1; i++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine("");
//    Console.Write(lineSpace);
//    num1 = num1 - 2;
//}
//Console.ReadKey();
    }
}