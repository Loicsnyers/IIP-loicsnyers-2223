using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ConsoleGGD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"BEREKEN GROOTST GEMENE DELER
============================");

            Console.Write("Getal 1:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Getal 2: ");
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            Console.WriteLine("De grootst gemene deler is: " + a);

            Console.ReadLine();
        }
    }
}
