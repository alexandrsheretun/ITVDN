using System;

namespace ConAppMenuProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("###Menu###");
            Console.WriteLine("View");
            Console.WriteLine("Info");
            Console.WriteLine("Edit");
            Console.Write("\n" + "Change your key : ");
            var ch = Console.ReadKey().Key;
            while(ch != ConsoleKey.Escape);
                switch (ch)
                {
                    case ConsoleKey.RightArrow:
                        {
                            Console.WriteLine("View");
                            break;
                        }

                    case ConsoleKey.LeftArrow:
                        {
                            Console.WriteLine("Info");
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            Console.WriteLine("Edit");
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.WriteLine("end program");
                            break;
                        }
                }
                
        }
    }

}
