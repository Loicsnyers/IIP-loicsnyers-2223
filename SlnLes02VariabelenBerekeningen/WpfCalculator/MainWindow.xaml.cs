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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            calcTxt.Text = btn.Content.ToString();
            second = Convert.ToInt32(calcTxt.Text);
            if (op == '+')
            {
                result.Content = first + second;
            }
            else if (op == '-')
            {
                result.Content = first - second; 
            }
            else if (op == '*')
            {
                result.Content = first * second;
            }
            else
            {
                result.Content = first / second;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(calcTxt.Text);
            second = Convert.ToInt32(calcTxt.Text);
            op = '+';
            calcTxt.Text = "";

        }

        private void substract_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(calcTxt.Text);
            second = Convert.ToInt32(calcTxt.Text);
            op = '-';
            calcTxt.Text = "";

        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(calcTxt.Text);
            second = Convert.ToInt32(calcTxt.Text);
            op = '*';
            calcTxt.Text = "";

        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(calcTxt.Text);
            second = Convert.ToInt32(calcTxt.Text);
            op = '/';
            calcTxt.Text = "";
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            calcTxt.Text = "";
            result.Content = null;
        }
    }
}
