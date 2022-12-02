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

namespace WpfInterest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double bedrag = Convert.ToDouble(bedrag1.Text);
            double interest = Convert.ToDouble(interest1.Text);

            interest = interest / 100;

            double berekening = bedrag * (Math.Pow( 1 + interest, slide1.Value) - 1);
            result.Text = ($"de waarde na " + slide1.Value + " jaar bedraagt " + (Math.Round(bedrag + berekening, 2)));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblValue.Content = Math.Round(slide1.Value);
        }
    }
}
