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

namespace WpfPizza
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

        private void option1_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "tomatensaus, mozzarella en oregano";
            imgPhoto.Source = new BitmapImage(new Uri("images/hot en spicy.png", UriKind.Relative));
        }

        private void option2_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "tomatensaus, mozzarella, rode ui, kip," + Environment.NewLine + "paprika, pepperoni en spaanse peppers";
            imgPhoto.Source = new BitmapImage(new Uri("images/4 seizoenen.png", UriKind.Relative));
        }

        private void option3_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "tomatensaus, mozzarella, ham en ananas";
            imgPhoto.Source = new BitmapImage(new Uri("images/hawai.png", UriKind.Relative));
        }
    }
}
