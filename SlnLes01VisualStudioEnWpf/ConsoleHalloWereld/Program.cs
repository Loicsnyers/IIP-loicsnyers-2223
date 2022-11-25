using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Wereld!");
            Console.Write("Hoe heet je:");
            string voornaam = Console.ReadLine();
            Console.Write("Aangename kennismaking,");
            Console.WriteLine(voornaam);
            Console.Write("Druk een toets om verder te gaan...");

            Console.ReadLine();
        }
    }
}
