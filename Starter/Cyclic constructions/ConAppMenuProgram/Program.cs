using System;

namespace ConAppMenuProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            int i = 0;

            array[0] = "View";
            array[1] = "Edit";
            array[2] = "Info";

            var ch = Console.ReadKey().Key;

            while (ch != ConsoleKey.Enter)
            {
                ch = Console.ReadKey().Key;
                array[0] = "View";
                array[1] = "Edit";
                array[2] = "Info";
                Console.Clear();
                switch (ch)
                {
                    case ConsoleKey.UpArrow:
                        if (i == 0)
                        {
                            i = array.Length - 1;
                            array[i] = "->" + array[i];
                        }
                        else
                        {
                            i = i - 1;
                            array[i] = "->" + array[i];
                        }

                        break;
                    case ConsoleKey.DownArrow:
                        if (i == 2)
                        {
                            i = 0;
                            array[i] = "->" + array[i];
                        }
                        else
                        {
                            i = i + 1;
                            array[i] = "->" + array[i];
                        }
                        break;
                }
                Console.WriteLine(array[0]);
                Console.WriteLine(array[1]);
                Console.WriteLine(array[2]);
            }
        }
    }

}
