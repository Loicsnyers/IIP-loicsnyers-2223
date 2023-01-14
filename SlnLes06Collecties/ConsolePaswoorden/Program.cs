using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoorden
{
    internal class Program
    {
         private static string[] passwords = new string[]
        {
            "klepketoe", "test", "Azerty123", "rogier@work", "password",  "MisterNasty12", "pwnz0red",
        };

         static List<string> okPasswords = new List<string>();
         static List<string> notOkPasswords = new List<string>();

         static void Main(string[] args)
         {
            Console.WriteLine("Alle paswoorden:");
            for (int i = 0; i < passwords.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + passwords[i]);
            }

            Console.ReadLine();

            foreach (string password in passwords)
            {
                if (IsCorrectPassword(password))
                {
                    okPasswords.Add(password);
                }
                else
                {
                    notOkPasswords.Add(password);
                }
            }

            Console.Write("Ok: ");
            Console.WriteLine(string.Join(", ", okPasswords));

            Console.Write("Niett ok: ");
            Console.WriteLine(string.Join(", ", notOkPasswords));

            Console.ReadLine();
         }

         private static bool IsCorrectPassword(string password)
         {
            if (password.Length < 8)
            {
                return false;
            }

            if (password.Contains("@"))
            {
                return false;
            }

            if (password == "123456789" || password == "password" || password == "Azerty123")
            {
                return false;
            }

            return true;
         }
    }
}
