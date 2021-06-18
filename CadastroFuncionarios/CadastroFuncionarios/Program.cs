using CadastroFuncionarios.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CadastroFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int quant = int.Parse(Console.ReadLine());
            List<Employee> Employees = new List<Employee>();

            for (int c = 1; c <= quant; c++)
            {
                Console.WriteLine($"Employee #{c} data:");
                Console.Write("Outsourced (y/n)? ");
                char x = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (x == 'n')
                {
                    Employees.Add(new Employee(name, hours, value));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee func = new OutsourcedEmployee(name, hours, value, addicionalCharge);
                    Employees.Add(func);
                }
            }
                Console.WriteLine("PAYMENTS:");
                foreach (Employee d in Employees)
                {
                    Console.WriteLine($"{d.Name} - $ {d.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }

            
            

        }
    }
}
