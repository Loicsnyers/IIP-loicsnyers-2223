using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEllipsen__2_
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

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int width = rnd.Next(10, 75);
            int height = rnd.Next(10, 65);

            for (int i = 0; i < 50; i++)
            {
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
    }
}
