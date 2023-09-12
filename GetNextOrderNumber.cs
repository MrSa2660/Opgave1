using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    internal class GetNextOrderNumber
    {
        public static int getNextOrderNumber()
        {
            int orderNumber = 1;
            while (File.Exists(Path.Combine(Menu.OutputFolder, $"C:/Users/ahmakk/Desktop/ordre_{orderNumber}.txt"))) // Specify the output folder
            {
                orderNumber++;
            }
            return orderNumber;
        }
    }
}
