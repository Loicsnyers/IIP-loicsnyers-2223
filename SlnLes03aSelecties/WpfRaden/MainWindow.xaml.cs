using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            int getal;
            int pogingenOver = 3;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            getal = rnd.Next(1, 11);
        }
        private void Btn_Control_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver--;
       
            int guess = Convert.ToInt32(Guess.Text);
           
            if (guess > getal)
            {
                result_guess.Content = $"Te hoog!, je hebt nog {pogingenOver} pogingen over.";
            }
            else if (guess < getal) 
            {
                result_guess.Content = $"Te laag!, je hebt nog {pogingenOver} pogingen over.";
            }
            else if (guess == getal)
            {
                result_guess.Content = "juist gegokt!";
                Btn_Control.IsEnabled= false; 
            }
            if (pogingenOver == 0)
            {
                Btn_Control.IsEnabled = false;
            }
        }
    }
}
