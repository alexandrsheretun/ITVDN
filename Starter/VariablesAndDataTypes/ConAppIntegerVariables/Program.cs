using System;

namespace ConAppIntegerVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            int result = a + b;
            Console.WriteLine("press any button to add");
            Console.ReadKey();
            Console.WriteLine("a + b = {0}", result);

            int result2 = a - b;
            Console.WriteLine("press any button to subtract");
            Console.ReadKey();
            Console.WriteLine("a - b = {0}", result2);

            int result3 = a / b;
            Console.WriteLine("press any button to split");
            Console.ReadKey();
            Console.WriteLine("a / b = {0}", result3);

            int result4 = a * b;
            Console.WriteLine("press any button to multiply");
            Console.ReadKey();
            Console.WriteLine("a * b = {0}", result4);

            Console.ReadKey();
        }
    }
}
