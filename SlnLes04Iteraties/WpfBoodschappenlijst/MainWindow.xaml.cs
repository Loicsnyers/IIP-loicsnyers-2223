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

namespace WpfBoodschappenlijst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] items = { "brood", "melk", "kaas", "olijven", "appels" };
            foreach (string item in items)
            {
                listBox.Items.Add(item);   
            }

            listBox.SelectionMode = SelectionMode.Multiple;

            listBox.SelectionChanged += ListBox_SelectionChanged;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = listBox.SelectedItems;

            string selectedItemsString = "";

            foreach (string item in selectedItems)
            {
                selectedItemsString += item + " ";
            }

            result.Text =$"je selecteerde: {selectedItemsString}";
        }
    }
}
