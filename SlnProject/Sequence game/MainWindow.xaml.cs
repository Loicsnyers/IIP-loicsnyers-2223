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

namespace Sequence_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] sounds;
        private SoundPlayer player;
        private bool isMuted = false;
        private int currentSound;
        private bool gameStarted;
        private StackPanel soundsStackPanel;

        public MainWindow()
        {
            this.InitializeComponent();
            this.gameStarted = false;
            this.soundsStackPanel = (StackPanel)this.FindName("SoundsStackPanel");

            this.player = new SoundPlayer(@"C:\Users\loics\source\repos\Loicsnyers\IIP-loicsnyers-2223\SlnProject\Sequence game\geluiden\backgroundsound.wav"); // line 48 to 50 looping background sound
            this.player.Load();
            this.player.PlayLooping();
        }

        private List<SoundPlayer> GenerateSounds(int numSounds)
        {
            List<SoundPlayer> sound = new List<SoundPlayer>();
            for (int i = 0; i < numSounds; i++)
            {
                SoundPlayer sounds = new SoundPlayer();

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
            }

            return sound;
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

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            this.currentSound = 0;
            this.gameStarted = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Tag.ToString() == this.sounds[this.currentSound])
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "geluiden/cheering.wav");
                SoundPlayer cheer = new SoundPlayer(path);
                cheer.Load();
                cheer.PlaySync();
            }
            else
            {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "geluiden/laugh.wav");
                SoundPlayer laugh = new SoundPlayer(path);
                laugh.Load();
                laugh.PlaySync();
            }
        }

        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        {
            this.gameStarted = false;
            this.currentSound = 0;
            this.startBtn.IsEnabled = true;
        }

        private void ReadyBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
