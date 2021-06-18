using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Bruno";
            conta1.Depositar(500);
            Console.WriteLine(conta1.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriela";

            bool resultTrans = conta1.Transferir(300, conta2);
            Console.WriteLine(resultTrans);
            Console.WriteLine("Saldo Gabriela = " + conta2.saldo);
            Console.WriteLine("Saldo Bruno = " + conta1.saldo);


            Console.ReadLine();



        }
    }
}
