using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaves___ConsoleSchrikkeljaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"SCHRIKKELJAAR
=============");

            bool close = false;

            while (!close)
            {
                Console.Write("Geef een jaartal:");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year == 0)
                {
                    close = true;
                }

                if (LeapYear(year))
                {
                    Console.WriteLine($"Het jaar {year} is een schrikkeljaar.");
                }
                else
                {
                    Console.WriteLine($"Het jaar {year} is geen schrikkeljaar.");
                }
            }

            Console.WriteLine("Bedankt en tot ziens.");
            Console.ReadLine();
        }

        private static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
