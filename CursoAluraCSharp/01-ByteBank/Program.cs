using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Gabriela";
            conta1.agencia = 863;
            conta1.numero = 863452;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriela";
            conta2.agencia = 863;
            conta2.numero = 863452;

            conta1 = conta2;

            Console.WriteLine(conta1 == conta2);

            conta2.saldo = 500;

            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta2.saldo);



            Console.ReadLine();
        }
    }
}
