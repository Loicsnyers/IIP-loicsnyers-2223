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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string highestbieder = Convert.ToString(name1.Text);
        int highestbid = Convert.ToInt32(bod1.Text);
        public MainWindow()
        {
            InitializeComponent();
            string highestbieder = Convert.ToString(name1.Text);
            int highestbid = Convert.ToInt32(bod1.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            result.Content = ($" {name1.Text} heeft met {bod1.Text} euro nu het hoogste bod!");

            if (bod1.Text != bod1.Text);
            {
                result.Content = ($" sorry {name1.Text} heeft momenteel {bod1.Text}  het hoogste bod!");
            }


        }
    }
}
