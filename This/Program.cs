using System;

namespace This {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto ("TV", 1500.0);

            Console.WriteLine(p.Nome + p.Preco);
        }
    }
}
