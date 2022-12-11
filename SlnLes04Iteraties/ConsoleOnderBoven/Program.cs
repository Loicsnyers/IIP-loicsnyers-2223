using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boven;
            int onder;

            Console.Write("Geef een ondergrens:");
             onder = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Geef een bovengrens:");
             boven = Convert.ToInt32(Console.ReadLine()); 

            while (boven <= onder)

            if (boven < onder)
            {
                Console.Write("Bovengrens mag niet kleiner zijn dan ondergrens. Geef een bovengrens:");
                boven = Convert.ToInt32(Console.ReadLine());
                }
            else if (boven == onder)
            {
                Console.Write("Bovengrens mag niet gelijk zijn aan de ondergrens. Geef een bovengrens:");
                boven = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"bereik: van {onder} tot {boven}");

            Console.ReadLine();
        }
    }
}
