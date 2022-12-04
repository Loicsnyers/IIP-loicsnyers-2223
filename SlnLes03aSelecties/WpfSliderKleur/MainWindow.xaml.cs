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

namespace WpfSliderKleur
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblValue.Content = Math.Round(lblSlider.Value);

            if (lblSlider.Value <= 25) 
            {
                lblValue.Foreground= new SolidColorBrush(Colors.Green);
            }
            else if (lblSlider.Value <= 50)
            {
                lblValue.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else if (lblSlider.Value <= 75)
            {
                lblValue.Foreground = new SolidColorBrush(Colors.Orange);
            }
            else
            {
                lblValue.Foreground = new SolidColorBrush(Colors.Red);
            }
            

        }
    }
}
