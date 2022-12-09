using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double exam1 = 0.0;
            double exam2 = 0.0;
            double exam3 = 0.0;
            double calculation;

            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("=====================");

            Console.WriteLine();

            Console.Write("Geef het cijfer dagelijks werk (op 20):");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("Geef het cijfer op het project (op 20):"); ;
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen (op 20):");
            exam3 = double.Parse(Console.ReadLine());

            calculation = ((30 * exam1 / 100) + (20 * exam2 / 100) + (50 * exam3 / 100)) / 20 * 100;

            if (calculation >= 82.5)
            {
                Console.WriteLine($"je eindcijer is {calculation}%");
                Console.WriteLine("-> grootste onderscheiding");
            }
            else if (calculation >= 75)
            {
                Console.WriteLine($"je eindcijer is {calculation}%");
                Console.WriteLine("->  grote onderscheiding");
            }
            else if (calculation >= 67.5)
            {
                Console.WriteLine($"je eindcijer is {calculation}%");
                Console.WriteLine("-> onderscheiding");
            }
            else if (calculation >= 50)
            {
                Console.WriteLine($"je eindcijer is {calculation}%");
                Console.WriteLine("-> voldoende");
            }
            else
            {
                Console.WriteLine($"je eindcijer is {calculation}%");
                Console.WriteLine("-> onvoldoende");
            }

                Console.ReadLine(); 
        }
    }
}
