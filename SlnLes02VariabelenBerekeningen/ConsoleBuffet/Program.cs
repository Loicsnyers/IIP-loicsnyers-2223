using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"WELKOM IN HET BUFFETRESTAURANT
==============================
                                
Alles is a volonte en dranken zijn inbegrepen!
!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");

            Console.ResetColor();
            const double SEIZOEN_BUFFETS = 18.5;
            const double DESSERT_BUFFETS = 7.95;
            const double KIDS_MENUS = 8.95;

            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"Aantal seizoensbuffets ({SEIZOEN_BUFFETS}):");
            string seizoenBuffets = Console.ReadLine();
            double gtl1 = Convert.ToDouble(seizoenBuffets);

            Console.Write($"Aantal dessertenbuffets ({DESSERT_BUFFETS}):");
            string dessertBuffets = Console.ReadLine();
            double gtl2 = Convert.ToDouble(dessertBuffets);

            Console.Write($"Aantal kids menus ({KIDS_MENUS}):");
            string kidsMenus = Console.ReadLine();
            double gtl3 = Convert.ToDouble(kidsMenus);

            Console.Write("Fooi (0 indien geen):");
            string fooi = Console.ReadLine();
            double gtl4 = Convert.ToDouble(fooi);

            double totaal = (gtl1 * SEIZOEN_BUFFETS) + (gtl2 * DESSERT_BUFFETS) + (gtl3 * KIDS_MENUS) + gtl4;
            Console.WriteLine($"Totaal te betalen:" + Math.Round(totaal, 2));

            Console.WriteLine($"Afgeronden naar beneden:" + Math.Floor(totaal));
            Console.WriteLine();

            Console.Write("Cash betaald");
            string cashBetaald = Console.ReadLine();
            int gtl5 = Convert.ToInt32(cashBetaald);

            int cash50 = 50;
            int cash20 = 20;
            int cash10 = 10;
            int cash5 = 5;
            int munt2 = 2;
            int munt1 = 1;

            int onecash50 = (int)(gtl5 / cash50);
            int onecash20 = (int)((gtl5 % cash50) / cash20);
            int onecash10 = (int)(((gtl5 % cash50) % cash20) / cash10);
            int onecash5 = (int)((((gtl5 % cash50) % cash20) % cash10) / cash5);
            int onemunt2 = (int)(((((gtl5 % cash50) % cash20) % cash10) % cash5) / munt2);
            int onemunt1 = (int)((((((gtl5 % cash50) % cash20) % cash10) % cash5) % munt2) / munt1);



            Console.WriteLine("U krijgt terug:");

            Console.WriteLine("- {0} briefje(s) van 50", onecash50);
            Console.WriteLine("- {0} briefje(s) van 20", onecash20);

            Console.WriteLine("- {0} briefje(s) van 10", onecash10);
            Console.WriteLine("- {0} briefje(s) van 5", onecash5);

            Console.WriteLine("- {0} stuk(ken) van 2", onemunt2);
            Console.WriteLine("- {0} stuk()ken van 1", onemunt1);

            Console.ReadLine();
        }
    }
}
