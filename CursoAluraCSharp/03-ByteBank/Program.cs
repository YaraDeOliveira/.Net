using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Gabriela";
            cliente1.Profissao = "Desenvolvedora C#";
            cliente1.Cpf = "521.543.125.68";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = cliente1;
            conta.agencia = 863;
            conta.saldo = 500;
            conta.numero = 5634527;

            Console.WriteLine(cliente1.Nome);
            Console.WriteLine(conta.titular.Nome);
            Console.ReadLine();
        }
    }
}
