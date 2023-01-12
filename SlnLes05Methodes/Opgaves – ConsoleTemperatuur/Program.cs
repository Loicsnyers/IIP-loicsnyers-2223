using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Opgaves___ConsoleTemperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            double temperature;
            double fahrenheit;
            double celsius;
            double kelvin;
            double celsius1;

            Console.WriteLine(@"TEMPERATUUR CONVERSIE
=====================");

            Console.WriteLine("a. Celsius naar Fahrenheit");
            Console.WriteLine("b. Fahrenheit naar Celsius");
            Console.WriteLine("c. Celsius naar Kelvin");
            Console.WriteLine("d. Kelvin naar Celsius");
            Console.WriteLine("x. Afsluiten");

            while (true)
            {
                Console.WriteLine("");
                Console.Write("Maak je keuze:");
                string input = Console.ReadLine().Trim();
                choice = input[0];

                if (choice == 'a' || choice == 'b' || choice == 'c' || choice == 'd' || choice == 'x')
                {
                    if (choice == 'a')
                    {
                        Console.Write("Celsius:");
                    }
                    else if (choice == 'b')
                    {
                        Console.Write("Fahrenheit:");
                    }
                    else if (choice == 'c')
                    {
                        Console.Write("Celsius:");
                    }
                    else if (choice == 'd')
                    {
                        Console.Write("Kelvin:");
                    }
                    else if (choice == 'x')
                    {
                        Console.WriteLine(@"

Bedankt en tot ziens");

                        System.Threading.Thread.Sleep(1500);
                        Environment.Exit(0);    
                    }

                    while (!double.TryParse(Console.ReadLine(), out temperature))
                    {
                        Console.Write("Invalid input, please enter a valid number.");
                    }

                    if (choice == 'a')
                    {
                        fahrenheit = Math.Round((temperature * 1.8) + 32, 2);
                        Console.WriteLine($"→ naar Fahrenheit: {fahrenheit}°F");
                    }
                    else if (choice == 'b')
                    {
                        celsius = Math.Round((temperature - 32) / 1.8, 2);
                        Console.WriteLine($"→ naar Celsius: {celsius}°C");
                    }
                    else if (choice == 'c')
                    {
                        kelvin = Math.Round(temperature + 273.15, 2);
                        Console.WriteLine($"→ naar Kelvin {kelvin}K");
                    }
                    else if (choice == 'd')
                    {
                        celsius1 = Math.Round(temperature - 273.15, 2);
                        Console.WriteLine($"→ naar Celsius {celsius1}°C");
                    }
                }
            }
        }
    }
}
