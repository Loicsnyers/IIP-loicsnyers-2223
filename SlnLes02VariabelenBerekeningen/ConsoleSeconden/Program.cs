using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeconden
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Geef het aantal seconden:");
            string seconden = Console.ReadLine();
            
            int dagen = Convert.ToInt32(seconden) / (24 * 60 * 60); // seconds get converted to days
            int dagen1 = Convert.ToInt32(seconden) % (24 * 60 * 60); // rest seconds are calculated here

            int uren = Convert.ToInt32(dagen1) / (60 * 60); // rest seconds from dagen1 are converted to uren
            int uren1 =Convert.ToInt32(seconden) % (60 * 60); // rest seconds from uren are calculated here

            int min = Convert.ToInt32(uren1) / (60); // rest seconds from uren1 are divised by 60 to get minutes
            int min1 = Convert.ToInt32(seconden) % (60);
           
            int sec = Convert.ToInt32(min1) * (60);
            int sec1 = Convert.ToInt32(seconden) % (60);









            Console.WriteLine($"Dit zijn {dagen} Dagen , {uren} uren  ,{min} min , {sec1} seconden");

            Console.ReadLine();
        }
    }
}
