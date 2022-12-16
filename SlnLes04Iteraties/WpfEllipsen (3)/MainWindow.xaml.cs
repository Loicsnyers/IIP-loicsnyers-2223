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

namespace WpfEllipsen__3_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            totalEllipses.ValueChanged += Slider_ValueChanged;
            minSlider.ValueChanged += Slider_ValueChanged;
            maxSlider.ValueChanged += Slider_ValueChanged;

            Slider_ValueChanged(null, null);
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            if (minSlider.Value > maxSlider.Value)
            {
                foutMelding.Content = "De minimum mag niet groter zijn dan de maximum straal";
                foutMelding.Foreground = Brushes.Red;
                return;
            }
            else
            {
                foutMelding.Content = "";
            }

            int totEllipses =(int)totalEllipses.Value;
            int minRadius = (int)minSlider.Value;
            int maxRadius = (int)maxSlider.Value;

            sliderTop.Content = totEllipses;
            sliderMid.Content = minRadius;
            sliderBot.Content = maxRadius;

            for (int i = 0; i < totEllipses; i++)
            {
                Random rnd = new Random();
                int width = rnd.Next(minRadius, maxRadius);
                int height = rnd.Next(minRadius, maxRadius);

                Ellipse ellipse = new Ellipse();
                ellipse.Width = width;
                ellipse.Height = height;

                byte r = (byte)rnd.Next(256);
                byte g = (byte)rnd.Next(256);
                byte b = (byte)rnd.Next(256);
                ellipse.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));

                int x = rnd.Next((int)canvas1.ActualWidth - (int)ellipse.Width);

                int y = rnd.Next((int)canvas1.ActualHeight - (int)ellipse.Height);

                Canvas.SetLeft(ellipse, x);
                Canvas.SetTop(ellipse, y);

                canvas1.Children.Add(ellipse);
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
