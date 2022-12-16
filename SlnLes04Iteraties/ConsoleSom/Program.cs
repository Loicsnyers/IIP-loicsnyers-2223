using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            
            string input = "";
            
            while (input != "q")
            {
                Console.Write("Voer een getal in (q om te stoppen): ");
                input = Console.ReadLine();
                
                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }
            }
            
            Console.WriteLine($"De som is: {sum}");

            Console.ReadLine();
        }

    }
}
