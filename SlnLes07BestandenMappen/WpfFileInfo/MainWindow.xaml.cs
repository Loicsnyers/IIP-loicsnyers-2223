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

namespace WpfFileInfo
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                FileInfo fileInfo= new FileInfo(filePath);

                txtFileName.Text = txtFileName.Text + fileInfo.Name;
                
                txtFileExtension.Text = txtFileExtension.Text + fileInfo.Extension;

                txtFileCreationTime.Text = txtFileCreationTime.Text + fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss");

                txtDirectory.Text = txtDirectory.Text + fileInfo.DirectoryName;

                string fileText = File.ReadAllText(filePath);
                string[] words = fileText.Split(' ');
                int totalWords = words.Length;
                txtTotalWords.Text = txtTotalWords.Text + totalWords.ToString();

                Dictionary<string, int> wordCounts = new Dictionary<string, int>();
                foreach (string word in words)
                {
                    string wordString = new string(word.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();

                    if (wordCounts.ContainsKey(wordString))
                    {
                        wordCounts[wordString]++;
                    }
                    else
                    {
                        wordCounts[wordString] = 1;
                    }
                }

                var top3Words = wordCounts.OrderByDescending(w => w.Value).Take(3);

                txtTopWords.Text = txtTopWords.Text + "";
                foreach (var word in top3Words)
                {
                    txtTopWords.Text += word.Key + " " + word.Value + "\n";
                }
            }
        }

    }
}
