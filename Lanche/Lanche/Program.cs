using System;

namespace Lanche {
    class Program {
        static void Main(string[] args) {
            string [] pedido = Console.ReadLine().Split();
            int cod = int.Parse(pedido[0]);
            int qtde = int.Parse(pedido[1]);
            double total = 0.0;
            if (cod == 1) {
                total = qtde * 4;
            } else if (cod == 2) {
                total = qtde * 4.5;
            } else if (cod == 3) {
                total = qtde * 5.0;
            } else if (cod == 4) {
                total = qtde * 2.0;
            } else {
                total = qtde * 1.5;
            }
            Console.WriteLine($"Total: R$ {total:f2}");
        }
    }
}
