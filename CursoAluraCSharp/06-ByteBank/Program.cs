using System;


namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 8645872) ;
            ContaCorrente conta1 = new ContaCorrente(867, 8654873);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();

        }
    }
}
