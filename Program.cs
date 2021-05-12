using System;
using System.Threading;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System Ready...");

            string command = Console.ReadLine();

            if (command == "run")
            {
                System.Console.WriteLine("Enter Password >>");

                string pass = Console.ReadLine();

                if (pass == "password")
                {
                    System.Console.WriteLine("Welcome.. Check out my additional programs within main.");

                    System.Console.WriteLine("Check out > day-of-the-week");

                    string check = Console.ReadLine();

                    if (check == "day-of-the-week")
                    {
                        System.Console.WriteLine("Welcome to day of the week!");

                        System.Console.WriteLine("Input day of week >");

                        string dayOfWeek = Console.ReadLine();

                        switch (dayOfWeek)
                        {
                            case "sunday":
                                System.Console.WriteLine("Its the last day of the weekend! No.1 day of the week");
                                break;
                            case "monday":
                                System.Console.WriteLine("Back to work. No.2 day of the week");
                                break;
                            case "tuesday":
                                System.Console.WriteLine("Time for Coffee. No.3 day of the week");
                                break;
                            case "wednwsday":
                                System.Console.WriteLine("Real Windy. No.4 day of the week");
                                break;
                            case "thursday":
                                System.Console.WriteLine("Man im thirsty. No.5 day of the week");
                                break;
                            case "friday":
                                System.Console.WriteLine("Time for a barbecue. No.6 day of the week");
                                break;
                            case "saturday":
                                System.Console.WriteLine("Day off! Yay! No.7 day of the week");
                                break;
                            default:
                                System.Console.WriteLine("That isnt a day! Check spelling.. ");
                                break;
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Invalid input");
                    }

                }
                else
                {
                    System.Console.WriteLine("Password Incorrect");
                }
            }
            else if (command == "end")
            {
                System.Console.WriteLine("Program Ended");
            }
        }
    }
}
