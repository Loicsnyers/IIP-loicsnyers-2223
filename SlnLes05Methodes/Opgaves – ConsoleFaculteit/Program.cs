using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaves___ConsoleFaculteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACULTEIT BEREKENEN");
            Console.WriteLine();

            Console.Write("Geef een geheel getal:");
            int number = int.Parse(Console.ReadLine());

            int formula = Faculteit(number);
            Console.WriteLine($"De faculteit is {formula}");

            Console.ReadKey();
        }

        private static int Faculteit(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
