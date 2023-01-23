using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantal = GenereerGetallen();
            int min = 0, max = 20;
            int[] getallen = GenereerGetallen(aantal, min, max);
            string scoreString = GetallenNaarString(getallen, ", ", " en ");
            Console.WriteLine("Scores: " + scoreString);

            Console.WriteLine();

            double averageScore = BepaalGemiddelde(getallen);
            Console.WriteLine("De gemmidelde score van de test was: " + averageScore);
            

            int worstScore = ZoekKleinste(getallen);
            Console.WriteLine("De slechtste score op de test was: " + worstScore);

            int bestScore = ZoekGrootste(getallen);
            Console.WriteLine("De beste score op de test was: " + bestScore);
            Console.ReadLine();
        }

        private static int GenereerGetallen()
        {
            Console.Write("Hoeveel scores wilt u genereren? ");
            return int.Parse(Console.ReadLine());
        }

        private static int[] GenereerGetallen(int aantal, int min, int max)
        {
            var random = new Random();
            int[] getallen = new int[aantal];

            for (int i = 0; i < aantal; i++)
            {
                getallen[i] = random.Next(min, max);
            }

            return getallen;
        }

        private static string GetallenNaarString(int[] getallen, string scheiding, string laatste)
        {
            string result = "";

            for (int i = 0; i < getallen.Length; i++)
            {
                if (i == getallen.Length - 2)
                {
                    result += getallen[i] + laatste + getallen[i + 1];
                    break;
                }
                else
                {
                    result += getallen[i] + scheiding;
                }
            }

            return result;
        }

        private static double BepaalGemiddelde(int[] getallen)
        {
            int sum = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                sum += getallen[i];
            }

            return (double)sum / getallen.Length;
        }

        private static int ZoekKleinste(int[] getallen)
        {
            int worstScore = getallen[0];
            for (int i = 1; i < getallen.Length; i++)
            {
                if (getallen[i] < worstScore)
                {
                    worstScore = getallen[i];
                }
            }

            return worstScore;
        }

        private static int ZoekGrootste(int[] getallen)
        {
            int bestScore = getallen[0];
            for (int i = 1; i < getallen.Length; i++)
            {
                if (getallen[i] > bestScore)
                {
                    bestScore = getallen[i];
                }
            }

            return bestScore;
        }
    }
}
