using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dude-perfect!");

            Console.WriteLine("Check out my equations! Try the Pythagorean Theorem using 23 and 45!");

            double pow = 2;

            double x = 23;

            double y = 45;

            double xpow = Math.Pow(x, pow);

            double ypow = Math.Pow(y, pow);

            double addedPow = xpow + ypow;

            double pythTh = Math.Pow(addedPow, pow);

            Console.WriteLine(pythTh);


        }
    }
}
