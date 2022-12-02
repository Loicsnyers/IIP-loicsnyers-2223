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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAlcohol
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

        private void slideTop_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblTop.Content = Math.Round(slideTop.Value);
            rct1.Width = Math.Round(slideTop.Value);
            rct1.Width = slideTop.Value * 35 + slideMid.Value *35;
            ;

            if (rct1.Width <= 175)
            {
                rct1.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (rct1.Width >= 250)
            {
                rct1.Fill = new SolidColorBrush(Colors.Red);
            }

        }

        private void slideMid_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMid.Content= Math.Round(slideMid.Value);
            rct1.Width= Math.Round(slideMid.Value);
            rct1.Width = slideTop.Value * 35 + slideMid.Value * 35 + slideBot.Value * 35;
            

            if (rct1.Width <= 175)
            {
                rct1.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (rct1.Width >= 250)
            {
                rct1.Fill = new SolidColorBrush(Colors.Red);
            }
        }

        private void slideBot_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblBot.Content= Math.Round(slideBot.Value);
            rct1.Width=Math.Round(slideBot.Value);
            rct1.Width = slideTop.Value * 35 + slideMid.Value * 35 + slideBot.Value * 35;
            

            if (rct1.Width <= 175)
            {
                rct1.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (rct1.Width >= 250)
            {
                rct1.Fill = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
