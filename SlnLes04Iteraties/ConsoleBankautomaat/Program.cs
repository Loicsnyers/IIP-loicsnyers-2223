using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            decimal balance = 500;

            Console.WriteLine(@"Bankautomaat
============");

            while (true)
            { 
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. stoppen");

                Console.Write("je keuze: ");
                string choice = Console.ReadLine();

                if (choice == "a")
                { 
                    Console.WriteLine();
                    Console.Write("Welk bedrag wil je afhalen: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    if (amount > balance)
                    {
                        Console.WriteLine();
                        Console.WriteLine("ongeldige keuze");
                        Console.WriteLine();
                    }
                    else
                    { 
                        balance -= amount;
                        Console.WriteLine($"afhaling ok - het nieuw saldo is {balance}.");
                        Console.WriteLine();
                    }
                }
                else if (choice == "b")
                {
                    Console.WriteLine();
                    Console.Write("Welk bedrag wil je storten: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    balance += amount;
                    Console.WriteLine($"storting ok - het nieuw saldo is {balance}.");
                    Console.WriteLine();
                }
                else if (choice == "c")
                {
                    Console.WriteLine();
                    Console.WriteLine("Bedankt en tot ziens.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ongeldige keuze");
                    Console.WriteLine();
                }
            }
        }
    }
}
