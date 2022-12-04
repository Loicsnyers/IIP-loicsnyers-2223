using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isGokJuist = false;
            int getal = 3;

            while (!isGokJuist)
            {
                Console.Write("Raad een getal tussen 1 en 10:");
                int gok = Convert.ToInt32(Console.ReadLine());

                if (gok < getal)
                {
                    Console.WriteLine("de gok was te laag");
                }
                else if (gok > getal)
                {
                    Console.WriteLine("de gok was te hoog");
                }
                else
                {
                    Console.WriteLine("Juist, je hebt gewonnen");
                    isGokJuist = true;
                }
                Console.ReadLine();
            }
        }
    }
}
