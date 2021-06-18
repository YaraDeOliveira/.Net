using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            
            conta1.titular.Nome = "Gabriela Costa";
            conta1.titular.Cpf = "434.562.878-20";
            conta1.titular.Profissao = "Desenvolvedora C#";

            conta1.saldo = 500;
            conta1.agencia = 563;
            conta1.numero = 5634527;

            Console.WriteLine(conta1.titular.Nome);
            Console.WriteLine(conta1.titular.Cpf);
            Console.WriteLine(conta1.titular.Profissao);
            Console.ReadLine();
        }
    }
}
