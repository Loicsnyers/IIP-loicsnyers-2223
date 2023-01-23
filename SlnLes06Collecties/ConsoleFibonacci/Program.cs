using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel Fibonacci getallen wil je afdrukken:");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacciNumbers = new int[n];

            generateFibonacciNumbers(fibonacciNumbers);
            Console.Write($"Eerste {n} Fibonacci getallen: ");
            printFibonacciNumbers(fibonacciNumbers);
            Console.ReadLine();
        }

        private static void generateFibonacciNumbers(int[] fibonacciNumbers)
        {
            if (fibonacciNumbers.Length > 0)
            {
                fibonacciNumbers[0] = 1;
            }
            if (fibonacciNumbers.Length > 1)
            {
                fibonacciNumbers[1] = 1;
            }

            for (int i = 2; i < fibonacciNumbers.Length; i++)
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
        }

        private static void printFibonacciNumbers(int[] fibonacciNumbers)
        {
            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                Console.Write(fibonacciNumbers[i]);

                if (i != fibonacciNumbers.Length - 1)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
