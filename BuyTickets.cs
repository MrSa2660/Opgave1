using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    internal class BuyTickets
    {
        public static void buyTickets()
        {
            Console.Write("Indtast beløb: ");
            double availableFunds = Convert.ToDouble(Console.ReadLine());

            int maxTickets = (int)(availableFunds / 120);
            Console.WriteLine($"Du kan købe op til {maxTickets} billetter.");

            Console.Write("Indtast antal billetter: ");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            if (numTickets * 120 > availableFunds)
            {
                Console.WriteLine("Beløb overskredet. Prøv igen.");
            }
            else
            {
                double totalPrice = numTickets * 120;
                double remainingFunds = availableFunds - totalPrice;

                Console.WriteLine($"Pris: {totalPrice} kr");
                Console.WriteLine($"Resterende penge: {remainingFunds} kr");
                Console.WriteLine($"Antal billetter købt: {numTickets}");

                int orderNumber = GetNextOrderNumber.getNextOrderNumber();
                string fileName = Path.Combine(Menu.OutputFolder, $"C:/Users/ahmakk/Desktop/ordre_{orderNumber}.txt"); // Specify the output folder

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine($"Pris: {totalPrice} kr");
                    sw.WriteLine($"Resterende penge: {remainingFunds} kr");
                    sw.WriteLine($"Antal billetter købt: {numTickets}");
                }

                Console.WriteLine($"Ordre gemt som {fileName}");
                Console.WriteLine($"Filen blev gemt i følgende mappe: {Path.GetFullPath(fileName)}"); // Display the file path
            }
        }
    }
}
