using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a distance in miles to convert it to kilometers: ");
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine($"{miles} = {Convert(miles)}km's");
            Console.ReadLine();
        }
        static double Convert(double miles)
        {
            return miles * 0.62137;
        }

    }
}
