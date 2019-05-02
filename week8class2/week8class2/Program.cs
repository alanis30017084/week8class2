using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8class2
{
    class Program
    {
        static int Calculate(int num1)
        {
            return -num1;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to change the sign: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write($"{Calculate(num1)}");
            Console.ReadLine();
        }
    }
}
