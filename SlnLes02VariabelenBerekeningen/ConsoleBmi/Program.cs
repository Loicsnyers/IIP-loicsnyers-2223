using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            Console.Write("Lengte (in cm):");
            string lengte = Console.ReadLine();

            int gtl1 = Convert.ToInt32(lengte);

            Console.Write("Gewicht (in kg):");
            string gewicht = Console.ReadLine();

            int gtl2 = Convert.ToInt32(gewicht);

            double bmi = gtl2 / Math.Pow(gtl1 / 100.0, 2);
            Console.WriteLine($"je BMI bedraagt:" + Math.Round(bmi, 1));

            Console.ReadKey();
        }
    }
}
