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

namespace _WpfIngredienten__vervolg__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            comboPeople.Items.Add("1");
            comboPeople.Items.Add("2");
            comboPeople.Items.Add("3");
            comboPeople.Items.Add("4");
            comboPeople.Items.Add("5");
            comboPeople.Items.Add("6");
            comboPeople.Items.Add("7");
            comboPeople.Items.Add("8");

            unitFirst.Items.Add("");
            unitFirst.Items.Add("g");
            unitFirst.Items.Add("kg");
            unitFirst.Items.Add("ml");
            unitFirst.Items.Add("cl");
            unitFirst.Items.Add("dl");
            unitFirst.Items.Add("l");

            unitScnd.Items.Add("g");
            unitScnd.Items.Add("kg");
            unitScnd.Items.Add("ml");
            unitScnd.Items.Add("cl");
            unitScnd.Items.Add("dl");
            unitScnd.Items.Add("l");

            unitThird.Items.Add("g");
            unitThird.Items.Add("kg");
            unitThird.Items.Add("ml");
            unitThird.Items.Add("cl");
            unitThird.Items.Add("dl");
            unitThird.Items.Add("l");

            unitFourth.Items.Add("g");
            unitFourth.Items.Add("kg");
            unitFourth.Items.Add("ml");
            unitFourth.Items.Add("cl");
            unitFourth.Items.Add("dl");
            unitFourth.Items.Add("l");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int people = Convert.ToInt32(comboPeople.Text);

            int quantity1 = Convert.ToInt32(much1.Text);
            int quantity2 = Convert.ToInt32(much2.Text);

            int quantity3 = Convert.ToInt32(much3.Text);
            int quantity4 = Convert.ToInt32(much4.Text);

            string measure1 = Convert.ToString(unitFirst.Text);
            string measure2 = Convert.ToString(unitScnd.Text);

            string measure3 = Convert.ToString(unitThird.Text);
            string measure4 = Convert.ToString(unitFourth.Text);

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
