using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"PIZZA BESTELLING
================
Kies je pizza");

            Console.WriteLine("a) Margherita 8 euro");
            Console.WriteLine("b) Funghi 10 euro");
            Console.WriteLine("c) Diabolo 11 euro");

            Console.Write("wat is je keuze?");

            var pizzaChoice = Console.ReadLine();
            double menuPrice = 0;
            string menuItem = "";

            if (pizzaChoice == "a")
            {
                menuItem = "Margherita";
                menuPrice = 8;
            }
            else if (pizzaChoice == "b")
            {
                menuItem = "Funghi";
                menuPrice = 10;
            }
            else if (pizzaChoice == "c")
            {
                menuItem = "Diabolo";
                menuPrice = 11;
            }

            Console.WriteLine();
            Console.WriteLine("Kies de grootte");
            Console.WriteLine("a) 15 cm (klein; - 20%)");
            Console.WriteLine("b) 20 cm (normaal)");
            Console.WriteLine("c) 25cm (groot; + 20%)");

            Console.Write("wat is je keuze?");

            var menuOption2 = Console.ReadLine();
            string pizzaGrootte = "";
            double sizePrice = 0;

            if (menuOption2 == "a")
            {
                pizzaGrootte = "klein";
                sizePrice = (20 * menuPrice) / 100;
                Convert.ToDouble(menuPrice - sizePrice);
            }
            else if (menuOption2 == "b")
            {
                pizzaGrootte = "normaal";
            }
            else if (menuOption2 == "c")
            {
                pizzaGrootte = "groot";
                sizePrice = (20 * menuPrice) / 100;
                Convert.ToDouble(menuPrice + sizePrice);
            }

            Console.WriteLine();
            Console.Write("thuis bezorgen (3 euro extra)? ja/nee:");
            var deliveryOption = Console.ReadLine();
            double totalPrice = menuPrice + sizePrice;

            bool delivery = false;
            if (deliveryOption == "ja")
            {
                totalPrice += 3;
                delivery= true;

            }
            else if (deliveryOption == "nee")
            {
                totalPrice += 0;
                delivery = false;
            }

            if (delivery)
            {
                Console.WriteLine($"Jouw bestelling: 1 pizza {menuItem} {pizzaGrootte}, voor {totalPrice} euro, thuis bezorgd ");
            }
            else
            {
                Console.WriteLine($"Jouw bestelling: 1 pizza {menuItem} {pizzaGrootte}, voor {totalPrice} euro.");
            }

            Console.ReadLine();
        }
    }
}
