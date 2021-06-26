using System;
using System.Collections.Generic;
using ImpostoDeRendaII.Entities;
using System.Globalization;

namespace ImpostoDeRendaII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int quant = int.Parse(Console.ReadLine());
            List<Contribuinte> lista = new List<Contribuinte>();
            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char x = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (x == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(anualIncome, name, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(anualIncome, name, numberEmployees));
                }
            }
            double sum = 0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Contribuinte obj in lista)
            {
                Console.WriteLine($"{obj.Name}: $ {obj.ImpostoDevido().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += obj.ImpostoDevido();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
