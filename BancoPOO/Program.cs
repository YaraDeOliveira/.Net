using System;
using System.Globalization;

namespace BancoPOO {
    class Program {
        static void Main(string[] args) {
            Conta c1;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opc = char.Parse(Console.ReadLine().ToLower());
            if (opc == 's') {
                Console.Write("Entre o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(numero, titular, deposito);
            } else {
                c1 = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

        }
    }
}
