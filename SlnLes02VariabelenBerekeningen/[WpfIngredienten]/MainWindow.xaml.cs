using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace _WpfIngredienten_
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
            int people = Convert.ToInt32(totalPeople.Text);

            int quantity1 = Convert.ToInt32(much1.Text);
            int quantity2 = Convert.ToInt32(much2.Text);

            int quantity3 = Convert.ToInt32(much3.Text);
            int quantity4 = Convert.ToInt32(much4.Text);

            string measure1 = Convert.ToString(unit1.Text);
            string measure2 = Convert.ToString(unit2.Text);

            string measure3 = Convert.ToString(unit3.Text);
            string measure4 = Convert.ToString(unit4.Text);

            string ingredient1 = Convert.ToString(ingr1.Text);
            string ingredient2 = Convert.ToString(ingr2.Text);

            string ingredient3 = Convert.ToString(ingr3.Text);
            string ingredient4 = Convert.ToString(ingr4.Text);

            int calculation1 = people * quantity1;
            int calculation2 = people * quantity2;

            int calculation3 = people * quantity3;
            int calculation4 = people * quantity4;

            result.Text = ($"- {calculation1} {measure1} {ingredient1}" + Environment.NewLine + $"- {calculation2} {measure2} {ingredient2}" + Environment.NewLine + $"- {calculation3} {measure3} {ingredient3}" + Environment.NewLine + $"- {calculation4} {measure4} {ingredient4}");

        }
    }
}
