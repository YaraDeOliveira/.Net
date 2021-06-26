using System;
using System.Globalization;
using ExcecoesExercicio.Entities;
using ExcecoesExercicio.Entities.Exceptions;

namespace ExcecoesExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c1 = new Conta(number, name, balance, limit);


            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {

                c1.Withdraw(amount);
                Console.WriteLine("New balance: " + c1.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }

            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }




}

