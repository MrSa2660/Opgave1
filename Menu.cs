using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    internal class Menu
    {
        public static readonly string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Specify the output folder

        static void Main()
        {
            Console.WriteLine("Velkommen til biografen!");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vælg en handling:");
                Console.WriteLine("1. Køb billetter");
                Console.WriteLine("2. Se gamle køb fra filer");
                Console.WriteLine("3. Afslut");
                Console.Write("Indtast dit valg (1/2/3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BuyTickets.buyTickets();
                        break;
                    case "2":
                        ReadOldPurchases.readOldPurchases();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        break;
                }
            }
        }
    }
}
