using System;

namespace IfElse {
    class Program {
        static void Main(string[] args) {
            /*Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) {
                Console.WriteLine("Par!");
            } else {
                Console.WriteLine("Impar!");*/
            /*Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12) {
                Console.WriteLine("Bom dia");
            } else if (hora >=12 && hora < 18) {
                Console.WriteLine("Boa tarde");
            } else {
                Console.WriteLine("Boa noite");
            }*/

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0;

            if (preco < 100.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.2;
            }
            Console.WriteLine(desconto);
            
        }
    }
}
