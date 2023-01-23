using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_sequence
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numSounds;
        private bool isMuted = false;
        SoundPlayer player = new SoundPlayer();
        int currentSound = 0;
        int correctGuesses = 0;
        int numberOfElements;
        List<SoundPlayer> sound = new List<SoundPlayer>();

        // These sounds are under Fair Use:
        // Copyright Disclaimer Under Section 107 of the Copyright Act in 1976; Allowance is made for
        // 'Fair Use' for purposes such as criticism, comment, news reporting, teaching, scholarship, and research.
        // Fair use is a use permitted by copyright statute that might otherwise be infringing.
        // Non - profit, educational or personal use tips the balance in favor of fair use.
        // All rights and credit go directly to its rightful owners.

        public MainWindow()
        {
            InitializeComponent();

            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\bradpittsound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\kanyesound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\christianbalesound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\travissound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\ryanreynoldssound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\rocky.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\liluzi.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\chiefkeefsound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\kawhisound.wav"));
            sound.Add(new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\WPF sequence\sounds\tobeymaguire.wav"));
            playBtn.IsEnabled = false;
            advanceBtn.IsEnabled = false;
            MuteButton.Visibility = Visibility.Visible;
            this.player = new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game\geluiden\backgroundsound.wav"); // line 48 to 50 looping background sound
            this.player.Load();
            this.player.PlayLooping();
            restartBtn.IsEnabled = false;
        }

        private static bool ValidateInput(string name, int value)
        {
            if (string.IsNullOrEmpty(name) || value < 8 || value > 10)
            {
              
                return false;
            }
            else
            {
                
                return true;
            }
        }

        private void advanceBtn_Click(object sender, RoutedEventArgs e)
        {
            playBtn.IsEnabled = true;
            Grid MainGrid = (Grid)Content;
            int numberOfElements = int.Parse(numSoundsTextBox.Text);

            if (numberOfElements == 8)
            {
                _0.Visibility = Visibility.Visible;
                _1.Visibility = Visibility.Visible;
                _2.Visibility = Visibility.Visible;
                _3.Visibility = Visibility.Visible;
                _4.Visibility = Visibility.Visible;
                _5.Visibility = Visibility.Visible;
                _6.Visibility = Visibility.Visible;
                _7.Visibility = Visibility.Visible;
                btn0.Visibility = Visibility.Visible;
                btn1.Visibility = Visibility.Visible;
                btn2.Visibility = Visibility.Visible;
                btn3.Visibility = Visibility.Visible;
                btn4.Visibility = Visibility.Visible;
                btn5.Visibility = Visibility.Visible;
                btn6.Visibility = Visibility.Visible;
                btn7.Visibility = Visibility.Visible;
                advanceBtn.Visibility = Visibility.Collapsed;
                name.Visibility = Visibility.Collapsed;
                soundsToGenerate.Visibility = Visibility.Collapsed;
                nameTextBox.Visibility = Visibility.Collapsed;
                numSoundsTextBox.Visibility = Visibility.Collapsed;

            }
            else if (numberOfElements == 9)
            {
                _0.Visibility = Visibility.Visible;
                _1.Visibility = Visibility.Visible;
                _2.Visibility = Visibility.Visible;
                _3.Visibility = Visibility.Visible;
                _4.Visibility = Visibility.Visible;
                _5.Visibility = Visibility.Visible;
                _6.Visibility = Visibility.Visible;
                _7.Visibility = Visibility.Visible;
                _8.Visibility = Visibility.Visible;
                btn0.Visibility = Visibility.Visible;
                btn1.Visibility = Visibility.Visible;
                btn2.Visibility = Visibility.Visible;
                btn3.Visibility = Visibility.Visible;
                btn4.Visibility = Visibility.Visible;
                btn5.Visibility = Visibility.Visible;
                btn6.Visibility = Visibility.Visible;
                btn7.Visibility = Visibility.Visible;
                btn8.Visibility = Visibility.Visible;
                advanceBtn.Visibility = Visibility.Collapsed;
                name.Visibility = Visibility.Collapsed;
                soundsToGenerate.Visibility = Visibility.Collapsed;
                nameTextBox.Visibility = Visibility.Collapsed;
                numSoundsTextBox.Visibility = Visibility.Collapsed;
            }
            else if (numberOfElements == 10)
            {
                _0.Visibility = Visibility.Visible;
                _1.Visibility = Visibility.Visible;
                _2.Visibility = Visibility.Visible;
                _3.Visibility = Visibility.Visible;
                _4.Visibility = Visibility.Visible;
                _5.Visibility = Visibility.Visible;
                _6.Visibility = Visibility.Visible;
                _7.Visibility = Visibility.Visible;
                _8.Visibility = Visibility.Visible;
                _9.Visibility = Visibility.Visible;
                btn0.Visibility = Visibility.Visible;
                btn1.Visibility = Visibility.Visible;
                btn2.Visibility = Visibility.Visible;
                btn3.Visibility = Visibility.Visible;
                btn4.Visibility = Visibility.Visible;
                btn5.Visibility = Visibility.Visible;
                btn6.Visibility = Visibility.Visible;
                btn7.Visibility = Visibility.Visible;
                btn8.Visibility = Visibility.Visible;
                btn9.Visibility = Visibility.Visible;
                advanceBtn.Visibility = Visibility.Collapsed;
                name.Visibility = Visibility.Collapsed;
                soundsToGenerate.Visibility = Visibility.Collapsed;
                nameTextBox.Visibility = Visibility.Collapsed;
                numSoundsTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void MuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.isMuted)
            {
                this.player.PlayLooping();
                this.MuteButton.Content = "Mute sound";
                this.isMuted = false;
            }
            else
            {
                this.player.Stop();
                this.MuteButton.Content = "Sound is muted";
                this.isMuted = true;
            }
        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = nameTextBox.Text;
            int value;
            bool isValidValue = int.TryParse(numSoundsTextBox.Text, out value);

            if (ValidateInput(name, value))
            {
                advanceBtn.IsEnabled = true;
            }
            else
            {
                advanceBtn.IsEnabled = false;
            }
        }

        private void numSoundsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = nameTextBox.Text;
            int value;
            bool isValidValue = int.TryParse(numSoundsTextBox.Text, out value);

            if (ValidateInput(name, value))
            {
                advanceBtn.IsEnabled = true;
            }
        }

        private void restartBtn_Click(object sender, RoutedEventArgs e)
        {
            currentSound= 0;
            restartBtn.Visibility = Visibility.Visible;
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
          sound[currentSound].Play();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 0)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 1)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 2)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 3)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 4)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 5)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 6)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 7)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
            if (CheckGuess(correctGuesses, currentSound))
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/victory.wav");
                SoundPlayer victory = new SoundPlayer(path);
                victory.Load();
                victory.PlaySync();
                MessageBox.Show("You won!");
                Environment.Exit(0); 
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 8)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
            if (CheckGuess(correctGuesses, currentSound))
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/victory.wav");
                SoundPlayer victory = new SoundPlayer(path);
                victory.Load();
                victory.PlaySync();
                MessageBox.Show("You won!");
                Environment.Exit(0);
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (currentSound == 9)
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
                currentSound++;
                correctGuesses++;
                sound[currentSound].Play();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
                currentSound--;
                restartBtn.IsEnabled = true;
            }
            if (CheckGuess(correctGuesses, currentSound))
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "sounds/victory.wav");
                SoundPlayer victory = new SoundPlayer(path);
                victory.Load();
                victory.PlaySync();
                MessageBox.Show("You won!");
                Environment.Exit(0);
            }
        }

        private static bool CheckGuess(int correctGuesses, int currentSound)
        {
            if (correctGuesses == currentSound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
