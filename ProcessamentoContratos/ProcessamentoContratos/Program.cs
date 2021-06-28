using ProcessamentoContratos.Entities;
using ProcessamentoContratos.Services;
using System;
using System.Globalization;

namespace ProcessamentoContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installment)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
