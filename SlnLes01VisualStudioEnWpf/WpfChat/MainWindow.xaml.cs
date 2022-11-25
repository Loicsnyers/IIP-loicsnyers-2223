using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting;
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

namespace WpfChat
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
            conv1.Text += "helpdesk says:" + Environment.NewLine;
            conv1.Text += "on your computer, go on my computer" + Environment.NewLine;
            conv1.Text += Environment.NewLine;
            conv1.Text += "customer says:" + Environment.NewLine;
            conv1.Text += "where is your computer" + Environment.NewLine;
            conv1.Text += Environment.NewLine;
            conv1.Text += "helpdesk says:" + Environment.NewLine;
            conv1.Text += "i mean the folder is in my computer in your computer" + Environment.NewLine;
            conv1.Text += Environment.NewLine;
            conv1.Text += name1.Text + "says:" + Environment.NewLine;
            conv1.Text += ber1.Text + Environment.NewLine;
        }
    }
}
