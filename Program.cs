using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dude-perfect!");

            Console.WriteLine("Check out my equations! Try the Pythagorean Theorem using 23 and 45!");

            var pow = 2;

            var x = 23;

            var y = 45;

            var xpow = Math.Pow(x, pow);

            var ypow = Math.Pow(y, pow);

            var addedPow = xpow + ypow;

            var pythTh = Math.Pow(addedPow, pow);

            Console.WriteLine(pythTh);


        }
    }
}
