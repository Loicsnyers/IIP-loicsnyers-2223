using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_OPGAVE___CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name ?");
            string name = Console.ReadLine();

            Console.Write("Length ?");
            int length = Convert.ToInt32(Console.ReadLine());

            int meter = length / 100;
            int centimeter = length % 100;

            Console.Write($"{name} you're {meter} meter and {centimeter} centimeter");

            Console.ReadKey(); 
        }
    }
}
