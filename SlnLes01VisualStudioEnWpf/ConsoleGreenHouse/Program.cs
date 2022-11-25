using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGreenHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WELKOM BIJ GREENHOUSE RESTAURANT ***");
            Console.WriteLine("=========================================");

            Console.WriteLine();

            Console.Write(" Kies een grootte (kleine of grote):");
            string grootte = Console.ReadLine();

            Console.Write(" Kies een Basis (quinoa, rijst of salade):");
            string basis = Console.ReadLine();

            Console.Write(" Kies een soort (vegan, zalm of kip):");
            string soort = Console.ReadLine();

            Console.WriteLine();

            Console.Write("je bestelling:");
            Console.WriteLine($"een {grootte} {basis} met {soort}");

            Console.ReadLine();
        }
    }
}
