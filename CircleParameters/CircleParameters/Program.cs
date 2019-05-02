using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a radius to calculate other parameters of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write($"Circumference = {Circumference(radius)}\nArea = {Area(radius)}");
            Console.ReadLine();
        }
        static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static double Area(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
