using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OPGAVE___CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type random number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
        
            

            Console.WriteLine("type another random number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int som;
            som = number1+ number2;

            int product;
            product= number1 * number2;

            double quotient;
            quotient = number1 / number2;

            int rest = number1 % number2;

            Console.WriteLine($"{som} {product} {quotient} {rest}");


            Console.ReadKey();





        }
    }
}
