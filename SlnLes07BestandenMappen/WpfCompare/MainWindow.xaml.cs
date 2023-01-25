using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfCompare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string file1;
        private string file2;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public MainWindow()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "text document|*.TXT;*.TEXT";
            openFileDialog.Multiselect = true;
            bool? dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == true)
            {
                string[] files = openFileDialog.FileNames.Select(filePath => System.IO.Path.GetFileName(filePath)).ToArray();
                listBox1.ItemsSource = files;
                listBox2.ItemsSource = files;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text1 = TextBlock1.Text;
            string text2 = TextBlock2.Text;

            var matches = text1.Intersect(text2);

            TextBlock2.Inlines.Clear();

            foreach (char c in text2)
            {
                Run run = new Run(c.ToString());
                if (matches.Contains(c))
                {
                    run.Foreground = Brushes.Red;
                }

                TextBlock2.Inlines.Add(run);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string selectedFileName = (string)listBox.SelectedItem;

            if (listBox == listBox1)
            {
                
                TextBlock1.Text = File.ReadAllText(openFileDialog.FileNames.Where(filePath => System.IO.Path.GetFileName(filePath) == selectedFileName).FirstOrDefault());
            }
            else if (listBox == listBox2)
            {
                TextBlock2.Text = File.ReadAllText(openFileDialog.FileNames.Where(filePath => System.IO.Path.GetFileName(filePath) == selectedFileName).FirstOrDefault());
            }
        }
    }
}
