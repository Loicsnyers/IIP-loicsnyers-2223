using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WpfFormChecking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            profile.Items.Add("1");
            profile.Items.Add("2");
            profile.Items.Add("3");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aantalfouten = 0;

            txtName.Content = "";

            if (lblName.Text == "")
            {
                txtName.Content = "naam moet ingevuld zijn";
                aantalfouten++;
            }

            txtMail.Content = "";

            if (lblMail.Text == "")
            {
                txtMail.Content = "Email moet ingevuld zijn";
                aantalfouten++;
            }

            bornDay.Content = "";

            if (date.Text == "")
            {
                bornDay.Content = "datum moet ingevuld zijn";
                aantalfouten++;
            }

            profile1.Content = "";

            if (profile.Text == "")
            {
                profile1.Content = "maak een keuze";
                aantalfouten++;
            }

            passwordRes.Content = "";

            if (psswrd.Password == "")
            {
                passwordRes.Content = "kies een passwoord";
                aantalfouten++;
            }

            {

                genderRes.Content = "";

                if (women1.IsChecked == true)
                {
                    genderRes.Content = "";
                }
                else if (man1.IsChecked == true)
                {
                    genderRes.Content = "";
                }
                else
                {
                    genderRes.Content = "kies een geslacht";
                    aantalfouten++;
                }
            }

            {
                interRes.Content = "";

                if (prog.IsChecked == true)
                {
                    interRes.Content = "";
                }
                else if (netw.IsChecked == true)
                {
                    interRes.Content = "";
                }
                else if (busi.IsChecked == true)
                {
                    interRes.Content = "";
                }
                else
                {
                    interRes.Content = "kies minstens een interesse";
                    aantalfouten++;

                }

                if (aantalfouten == 0)
                {
                    finalResult.Content = "bedankt voor de registratie";
                }
                else
                {
                    finalResult.Content = ($"dit formulier bevat {aantalfouten} fouten");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblName.Text = "";
            lblMail.Text = "";
            date.Text = "";
            profile.Text = "";
            psswrd.Password = "";
            women1.IsChecked = false;
            man1.IsChecked = false;
            prog.IsChecked = false; 
            netw.IsChecked = false;
            busi.IsChecked = false;
        }
    }
}
