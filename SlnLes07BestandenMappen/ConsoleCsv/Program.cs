using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCsv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd= new Random();

            List<string> names = new List<string> { "Marie", "Zakaria", "Jessica", "John", "Emily", "Jacob", "Sophia", "Michael", "Madison", "Emma" };
            string[] games = { "Schaken", "Dammen", "Backgammon" };
            List<string> matchResults = new List<string>(); 

            for (int i = 1; i <= 100; i++)
            {
                int player1Index = rnd.Next(names.Count);
                int player2Index = rnd.Next(names.Count);

                while (player1Index == player2Index)
                {
                    player2Index = rnd.Next(names.Count);
                }

                string player1 = names[player1Index];
                string player2 = names[player2Index];
                string game = games[rnd.Next(games.Length)];

                int matchOutcome = rnd.Next(4);
                int player1Score = 0;
                int player2Score = 0;

                switch (matchOutcome)
                {
                    case 0:
                        player1Score = 1;
                        player2Score = 2; 
                        break;
                    case 1:
                        player1Score = 2;
                        player2Score = 1;
                        break;
                    case 2:
                        player1Score = 3;
                        player2Score = 0;
                        break;
                    case 3:
                        player1Score = 0;
                        player2Score = 3;
                        break;
                }
                

                matchResults.Add(i + ";" + player1 + ";" + player2 + ";" + game + ";" + player1Score + "-" + player2Score);

                using (StreamWriter sw = new StreamWriter("matchResults.csv")) // filePath C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnLes07BestandenMappen\ConsoleCsv\bin\Debug
                {
                    foreach (string result in matchResults)
                    {
                        sw.WriteLine(result);   
                    }
                }
            }
        }
    }
}
