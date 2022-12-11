using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering?");
            int seconds = int.Parse(Console.ReadLine());

            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine($"{i}...");
                System.Threading.Thread.Sleep(1000); 
            }

            Console.WriteLine("Lift off!");
            Console.ReadLine();
        }
    }
}
