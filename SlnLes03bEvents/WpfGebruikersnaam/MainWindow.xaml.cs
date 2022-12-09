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

namespace WpfGebruikersnaam
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            bool heeftSpatie = textBox.Text.Contains(" ");
            bool heeftHoofdLetters = textBox.Text.Any(c => char.IsUpper(c));

            if (heeftSpatie)
            {
                textBox.Background = System.Windows.Media.Brushes.Red;
                result.Content = "mag geen spaties bevatten.";
            }
            else if (heeftHoofdLetters == false)
            {
                textBox.Background = System.Windows.Media.Brushes.Red;
                result.Content = "moet een hoofdletter bevatten.";
            }
            else if (heeftSpatie == false && heeftHoofdLetters == true)
            {
                textBox.Background = System.Windows.Media.Brushes.Green;
                result.Content = "";
            }
        }
    }
}