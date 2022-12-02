using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OPGAVE___CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number ?");
            int input = Convert.ToInt32(Console.ReadLine());

            Double resultaat = Math.Pow(5, 2);

            Console.WriteLine($"square of {input} is {resultaat}");

            Console.ReadKey();




        }
    }
}
