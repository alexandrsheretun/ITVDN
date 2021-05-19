using System;

namespace ConAppSurfaceArea
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.Write("Enter the radius of the cylinder : ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the cylinder : ");
            double h = Convert.ToDouble(Console.ReadLine());
            double result = pi * Math.Pow(R, 2) * h;
            Console.WriteLine("The volume of the cylinder is = {0}", result);
            Console.ReadKey();

            Console.Write("\nEnter the radius of the cylinder : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the cylinder : ");
            double H = Convert.ToDouble(Console.ReadLine());
            double result1 = 2 * pi * r * (r + H);
            Console.WriteLine("The surface area of the cylinder is = {0}", result1);
            Console.ReadKey();
        }
    }
}
