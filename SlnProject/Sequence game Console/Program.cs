using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.IO;

namespace Sequence_game_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] sounds = { "bradpittsound.wav", "kanyesound.wav", "christianbalesound.wav", "travissound.wav", "ryanreynoldssound.wav", "asaprocky.wav", "liluzi.wav", "chiefkeefsound.wav", "kawhisound.wav", "tobeymaguire.wav" };
            string[] soundAnswers = { "brad pitt", "kanye west", "christian bale", "travis scott", "ryan reynolds", "asap rocky", "lil uzi vert", "chief keef", "kawhi leonard", "tobey maguire" };

            int currentSound = 0; // keeps track of the sound that is playing


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" __        _______ _     ____ ___  __  __ _____   _____ ___    __  ____   __  ____  _____ ___  _   _ _____ _   _  ____ _____    ____    _    __  __ _____ _ 
 \ \      / / ____| |   / ___/ _ \|  \/  | ____| |_   _/ _ \  |  \/  \ \ / / / ___|| ____/ _ \| | | | ____| \ | |/ ___| ____|  / ___|  / \  |  \/  | ____| |
  \ \ /\ / /|  _| | |  | |  | | | | |\/| |  _|     | || | | | | |\/| |\ V /  \___ \|  _|| | | | | | |  _| |  \| | |   |  _|   | |  _  / _ \ | |\/| |  _| | |
   \ V  V / | |___| |__| |__| |_| | |  | | |___    | || |_| | | |  | | | |    ___) | |__| |_| | |_| | |___| |\  | |___| |___  | |_| |/ ___ \| |  | | |___|_|
    \_/\_/  |_____|_____\____\___/|_|  |_|_____|   |_| \___/  |_|  |_| |_|   |____/|_____\__\_\\___/|_____|_| \_|\____|_____|  \____/_/   \_\_|  |_|_____(_)");

            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine();
            Console.WriteLine(@"Game course of action ||
- You'll have the choice to generate 8 to 10 sounds.
- Each time you make a correct guess a cheering sound will play.
- If you fail to guess correctly a saddening sound will play.
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(@"Game instructions ||
- Guess the correct rapper or actor.
- The more times you guess the right rapper or actor, the more difficult the guessing becomes.
- If you fail to guess the correct rapper or actor the game restarts.
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine();

            Console.Write("Before we know start the game i would like to know your name: ");
            string name = Console.ReadLine();
            Console.Write($"Hello {name} how many sounds do you want to generate (8-10)? ");
            int generatedSounds = int.Parse(Console.ReadLine());

            if (generatedSounds < 8 || generatedSounds > 10)
            {
                Console.WriteLine("Invalid input. Number of sounds must be between 8 and 10.");

                return;
            }

            List<SoundPlayer> sound = new List<SoundPlayer>();

            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\bradpittsound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\kanyesound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\christianbalesound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\travissound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\ryanreynoldssound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\asaprocky.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\liluzi.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\chiefkeefsound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\kawhisound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game Console\sounds\tobeymaguire.wav"));

            sound[0].Play();
            sound[1].Play();
            sound[2].Play();
            sound[3].Play();
            sound[4].Play();
            sound[5].Play();
            sound[6].Play();
            sound[7].Play();
            sound[8].Play();
            sound[9].Play();


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine();
            Console.Write($"Awesome choice {name} you have chosen for {generatedSounds} sounds!\nTo start the game, type 'ready' and press enter:");

            string input = string.Empty;
            while (input.Trim() != "ready") // when user did spacebar before ready, the console didn't clear so i used the input.trim() .trim removes all leading and trailing whitespaces from the current string.
            {
                input = Console.ReadLine().ToLower();
            }

            Console.Clear();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                StartCountdown("press enter to start the countdown...", 3);

                int correctGuesses = 0;
                for (int i = 0; i < generatedSounds; i++)
                {
                    Console.WriteLine($"sound {currentSound + 1} is playing...", i + 1);
                    sound[i].Play();


                    System.Threading.Thread.Sleep(750);

                    Console.Write($"Enter you guess for sound {currentSound + 1}: ");

                    string guess = Console.ReadLine();

                    if (guess == soundAnswers[currentSound])
                    {
                        Console.WriteLine("Correct guess!");
                        string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheeringsound.wav");
                        SoundPlayer cheer = new SoundPlayer(path);
                        cheer.Load();
                        cheer.PlaySync();
                        currentSound++;
                        correctGuesses++;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess!");
                        string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laughing.wav");
                        SoundPlayer laugh = new SoundPlayer(path);
                        laugh.Load();
                        laugh.PlaySync();
                        Console.WriteLine();
                        Console.WriteLine("you Lost, press enter to play again");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (correctGuesses == generatedSounds)
                    {
                        Console.Clear();
                        Console.WriteLine(@"         _nnnn_                      
        dGGGGMMb     ,"""""""""""""""""""""""""""".
       @p~qp~~qMb    |   You won  ! |
       M|@||@) M|   _;..............'
       @,----.JM| -'
      JS^\__/  qKL
     dZP        qKRb
    dZP          qKKb
   fZP            SMMb
   HZM            MMMM
   FqM            MMMM
 __| "".        |\dS""qML
 |    `.       | `' \Zq
_)      \.___.,|     .'
\____   )MMMMMM|   .'
     `-'       `--'");
                        string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/victory.wav");
                        SoundPlayer victory = new SoundPlayer(path);
                        victory.Load();
                        victory.PlaySync();
                    }
                }
            }
        }

        private static bool StartCountdown(string message, int seconds)
        {
            Console.Write(message);
            Console.ReadLine();
            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine($"{i} ...");
                System.Threading.Thread.Sleep(1000);
            }

            return true;
        }
    }
}
