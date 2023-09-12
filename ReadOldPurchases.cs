using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    internal class ReadOldPurchases
    {
        public static void readOldPurchases()
        {
            Console.WriteLine("Tidligere køb:");

            int orderNumber = 1;

            while (File.Exists(Path.Combine(Menu.Desktop, $"ordre_{orderNumber}.txt"))) // Specify the output folder
            {
                string fileName = Path.Combine(Menu.Desktop, $"ordre_{orderNumber}.txt"); // Specify the output folder

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.WriteLine(); // Separation between orders
                orderNumber++;
            }

            if (orderNumber == 1)
            {
                Console.WriteLine("Ingen tidligere køb fundet.");
            }
            Console.ReadKey();
        }
    }
}
