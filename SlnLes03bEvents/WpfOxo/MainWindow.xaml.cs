using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfOxo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        { 
            Button button = (Button)sender;

            button.Content = currentPlayer;

            button.IsEnabled = false;

            if (CheckForWin())
            {
                string message = "speler " + currentPlayer + " is gewonnen!";
                MessageBox.Show(message);

                DisableAllButtons();
            }

            else if (turnsTaken == 9)
            {
                string message = "gelijk!";
                MessageBox.Show(message);
            }

            else
            {
                if (currentPlayer == "X")
                {
                    currentPlayer = "O";
                }
                else
                {
                    currentPlayer = "X";
                }

                turnsTaken++;
            }
        }

        private bool CheckForWin()
        {
            if ((button1.Content == currentPlayer && button2.Content == currentPlayer && button3.Content == currentPlayer) ||
                (button4.Content == currentPlayer && button5.Content == currentPlayer && button6.Content == currentPlayer) ||
                (button7.Content == currentPlayer && button8.Content == currentPlayer && button9.Content == currentPlayer))
            {
                return true;
            }

            if ((button1.Content == currentPlayer && button4.Content == currentPlayer && button7.Content == currentPlayer) ||
                (button2.Content == currentPlayer && button5.Content == currentPlayer && button8.Content == currentPlayer) ||
                (button3.Content == currentPlayer && button6.Content
        }
}
