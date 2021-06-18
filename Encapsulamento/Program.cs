using System;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto ("TV", 1500, 3);

            Console.WriteLine(p1.GetNome());

            p1.SetNome("TV 4K");

            Console.WriteLine(p1.GetNome()) ;

            Console.WriteLine(p1.GetPreco());

        }
    }
}
