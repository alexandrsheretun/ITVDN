using System;

namespace ConAppDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
            //Block 1
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //Block 2
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            //Block 3
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            //Block 4 
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
            //Block 5
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                if (number == -1)
                    break;
                Console.WriteLine(number);
            }
        }
    }
}
