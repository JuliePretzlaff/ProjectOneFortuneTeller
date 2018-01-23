using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOneFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collecting and assigning user input to declared variables

            Console.WriteLine("Hello!  Welcome to the Fortune Teller! You may quit this program at any time by entering \"quit\". \n To begin, please enter your first name:");
            string firstName = Console.ReadLine().ToLower();
            //Code to allow user to quit program (currently only added for user inputs that are strings, not integers)
            if(firstName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                goto Finish;
            }

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine().ToLower();
            if (lastName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                goto Finish;
            }

            Console.WriteLine("Please enter your age:");
            ////Attempt to figure out how to quit the program when the user input is an integer (unsuccessful!):
            //int age;
            //if (Console.ReadLine() == "quit")
            //{
            //    Console.WriteLine("Nobody likes a quitter...");
            //    goto Finish;
            //}
            //else
            //{
            //    age = int.Parse(Console.ReadLine());
            //}
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birthmonth (in the form of a number/integer)");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite color from the following: R O Y G B I V.  Type \"help\" to view the color selection menu.");
            string color = Console.ReadLine().ToLower();
            if (color == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                goto Finish;
            }
            if (color == "help")
            {
                Console.WriteLine("color Selection Menu: \nR = Red \nO = Orange \nY = Yellow \nG = Green \nB = Blue \nI = Indigo \nV = Violet \nPlease enter your favorite color:");
                color = Console.ReadLine();
            }

            Console.WriteLine("Please enter the number of siblings you have:");
            int sibling = int.Parse(Console.ReadLine());


            //Calculating retirement age
            int yearsUntilRetire;
            if (age % 2 == 1)
            {
                yearsUntilRetire = 31;
            }
            else
            {
                yearsUntilRetire = 25;
            }

            //Choosing a vacation home
            string vacationHome;
            if(sibling < 0)
            {
                vacationHome = "Oscar the Grouch's trashcan";
            }
            else if(sibling >3)
            {
                vacationHome = "Shangri La";
            }
            else if(sibling ==0)
            {
                vacationHome = "Lake Tahoe, California";
            }
            else if (sibling == 1)
            {
                vacationHome = "Big Sky, Montana";
            }
            else if (sibling == 2)
            {
                vacationHome = "Telluride, Colorado";
            }
            else if (sibling == 3)
            {
                vacationHome = "Coroico, Bolivia";
            }
            else
            {
                vacationHome = "Cleveland, Ohio";
            }

            //Determining mode of transportation
            string transportation;
            switch (color)
            {
                case "r":
                    transportation = "X wing fighter";
                    break;

                case "o":
                    transportation = "hot air baloon";
                    break;

                case "y":
                    transportation = "camel caravan";
                    break;

                case "g":
                    transportation = "space X rocket";
                    break;

                case "b":
                    transportation = "G6 airplane";
                    break;

                case "i":
                    transportation = "raft";
                    break;

                case "v":
                    transportation = "walking stick";
                    break;

                default:
                    transportation = "barrel over Niagara Falls";
                    break;
            }

            //Calculating money in the bank
            double moneyInBank;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyInBank = -1.98;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = 2.00;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = 8888888.88;
            }
            else
            {
                moneyInBank = 0.00;
            }


            //Returning the user's fortune
            Console.WriteLine("Here is your fortune:");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetire + " years, with $" + moneyInBank + " in the bank, a vacation home in " + vacationHome + ", and a " + transportation + ".");

        //Finish point for quitting the program
        Finish:;




        }
    }
}
