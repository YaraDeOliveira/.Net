using System;
using System.IO;
using Exercicio.Entities;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\OneDriveTemp\myfolder\Sheet1.csv";
            string targetpath = @"C:\OneDriveTemp\myfolder\out\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quant = int.Parse(fields[2]);
                        Product p1 = new Product(name, price, quant);
                        Console.WriteLine(p1.Name +","+p1.Total().ToString("F2", CultureInfo.InvariantCulture));

                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
