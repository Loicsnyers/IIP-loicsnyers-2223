using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 7;
            int guess;
            int guessesLeft = 0;

            Console.WriteLine("Raad een getal tussen 1 en 10");

            do
            {
                Console.Write("poging 1:");
                guess = int.Parse(Console.ReadLine());
                guessesLeft++;

                if (guess == secretNumber)
                {
                    Console.WriteLine("Geraden");
                    break;
                }

                Console.Write("poging 2:");
                guess = int.Parse(Console.ReadLine());
                guessesLeft++;

                if (guess == secretNumber)
                {
                    Console.WriteLine("Geraden");
                    break;
                }

                Console.Write("poging 3:");
                guess = int.Parse(Console.ReadLine());
                guessesLeft++;

                if (guess == secretNumber)
                {
                    Console.WriteLine("geraden");
                    break;
                }

            } while (guess != secretNumber && guessesLeft < 3);

            if (guessesLeft == 3 && guess != secretNumber)
            {
                Console.WriteLine("Volgende keer beter");
            }

            Console.ReadLine();
        }
    }
}
