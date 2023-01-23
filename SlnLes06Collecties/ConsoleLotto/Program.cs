using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLotto
{
    internal class Program
    {
        const int MIN_NUMBER = 1;
        const int MAX_NUMBER = 42;
        const int NUM_WINNING_NUMBERS = 6;
        const int NUM_USER_NUMBERS = 6;

        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(@"WELKOM OP DE LOTTOTREKKING
==========================");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine();

            int[] winningNumbers = { 4, 8, 17, 22, 31, 39, 41 };
            int[] userNumbers = new int[NUM_USER_NUMBERS];

            Console.Write($"Geef {NUM_USER_NUMBERS} getallen tussen {MIN_NUMBER} en {MAX_NUMBER} gescheiden door spaties: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                userNumbers = GenereerGetallen();
            }
            else
            {
                string[] inputNumbers = userInput.Split(' ');

                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    userNumbers[i] = int.Parse(inputNumbers[i]);
                }
            }

            List<int> correctNumbers = Gemeenschappelijkewaarden(winningNumbers, userNumbers);

            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (Array.IndexOf(winningNumbers, userNumbers[i]) != -1)
                {
                    correctNumbers.Add(userNumbers[i]);
                }
            }

            Console.Write("Trekking:");
            for (int i = 0; i < winningNumbers.Length; i++)
            {
                if (i == winningNumbers.Length - 1)
                {
                    Console.Write(winningNumbers[i]);
                }
                else
                {
                    Console.Write(winningNumbers[i] + ", ");
                }
            }

            Console.WriteLine();
            Console.Write($"Je hebt {correctNumbers.Count} juist:");
            for (int i = 0; i < correctNumbers.Count; i++)
            {
                if (i == correctNumbers.Count - 1)
                {
                    Console.Write(correctNumbers[i]);
                }
                else
                {
                    Console.Write(correctNumbers[i] + ", ");
                }
            }

            Console.ReadLine();

        }

        private static int[] GenereerGetallen()
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();

            while (numbers.Count < NUM_WINNING_NUMBERS)
            {
                int nextnumber = rnd.Next(MIN_NUMBER, MAX_NUMBER + 1);

                if (!numbers.Contains(nextnumber))
                {
                    numbers.Add(nextnumber);
                }
            }

            numbers.Sort();
            return numbers.ToArray();
        }

        private static List<int> Gemeenschappelijkewaarden(int[] winningNumbers, int[] userNumbers)
        {
            List<int> correctNumbers = new List<int>();
            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (Array.IndexOf(winningNumbers, userNumbers[i]) != - 1)
                {
                    correctNumbers.Add(userNumbers[i]);
                }
            }

            return correctNumbers;
        }
    }
}
