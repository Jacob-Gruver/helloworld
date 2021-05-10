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
                    System.Console.WriteLine("Welcome.. ");
                }
                else
                {
                    System.Console.WriteLine("Password Incorrect");
                }
            }
            else if (command == "end")
            {
                System.Console.WriteLine("Program Ending");
            }
        }
    }
}
