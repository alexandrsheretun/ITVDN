using System;

namespace ConAppThreeVariablesInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            int result1 = x += y - x++ * z;
            Console.WriteLine("result of the first equation = {0}", result1);
            int result2 = z = --x - y * 5;
            Console.WriteLine("result of the second equation = {0}", result2);
            int result3 = y /= x + 5 % z;
            Console.WriteLine("result of the third equation = {0}", result3);
            int result4 = z = x++ + y * 5;
            Console.WriteLine("result of the fourth equation = {0}", result4);
            int result5 = x = y - x++ * z;
            Console.WriteLine("result of the fifth equation = {0}", result5);
            Console.ReadKey();
        }
    }
}
