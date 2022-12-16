using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Geef een tekst:");
            string input = Console.ReadLine();

            int klinkers = 0;
            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    klinkers++;
                }
            }

            Console.WriteLine($"deze tekst bevat {klinkers} klinkers");

            string secret = "";
            foreach (char c in input)
            {
                char secretMessage = Convert.ToChar(c + 1);
                secret += secretMessage;
            }

            Console.WriteLine($"in geheimschrift: {secret}");
            Console.ReadKey();

            
        }
    }
}
