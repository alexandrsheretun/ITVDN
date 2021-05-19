using System;

namespace ConAppConstPi
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("set the number R");
            var R = Convert.ToDouble(Console.ReadLine());
            double result = pi * Math.Pow(R, 2);            
            Console.WriteLine("The area of the circle is = {0}", result);
            Console.ReadKey();

        }
    }
}
