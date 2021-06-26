using ByteBank.Entities;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CarregarContas();
            }

            catch (Exception)
            {
                Console.WriteLine("Catch no metodo main");
            }










            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(100, 4578420);
            //    ContaCorrente conta2 = new ContaCorrente(485, 456478);

            //    conta2.Transferir(10000, conta);

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(-500);
            //}
            //catch (ArgumentException exc)
            //{
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException") ;
            //    Console.WriteLine("Argumento com problema: " + exc.ParamName);
            //    Console.WriteLine(exc.Message);
            //}

            //catch (SaldoInsuficienteException exc)
            //{
            //    Console.WriteLine(exc.Saldo);
            //    Console.WriteLine(exc.ValorSaque);

            //    Console.WriteLine(exc.StackTrace);

            //    Console.WriteLine(exc.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}

            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                //IDsiposable
                leitor.LerProximaLinha();
            }



            //LeitorDeArquivos leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivos("contas1.txt");
                
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha(); 
            //}
          
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}

        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 452984);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine();
                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna )");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
        }
    }
}
