using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OPGAVE___CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de hoogte van de regenput (in cm):");
            int hoogte = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("geef de diamter in van de regenput (in cm):");
            int diameter = Convert.ToInt32(Console.ReadLine());

            double hoogteInMeter = (double)hoogte / 100;
            double diameterInMeter = (double)hoogte / 100;

            double straal = (double) diameter / 2;
            double oppervlakteGrondvlak = straal * straal * Math.PI;
            double inhoudRegenput = oppervlakteGrondvlak * hoogte / 1000;

            double inhoudRegenputInKubiekeMeter = inhoudRegenput / 1000;

            Console.WriteLine("Een regenput met een hoogte van" 
                + hoogteInMeter.ToString("0.00") 
                "en een diameter van"+ diameterInMeter.ToString("0.00")
                + "en heeft een capaciteit van"
           inhoudRegenput.ToString("0.00")
           + "liter of omgerekend"
            Console.WriteLine(Math.Round(inhoudRegenput, 2)); 

            Console.ReadLine(); 
        }
    }
}
