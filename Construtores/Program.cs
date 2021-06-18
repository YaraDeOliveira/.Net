using System;
using System.Globalization;

namespace Construtores {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double prec = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quant = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, prec, quant);

            Produto p = new Produto(nome, prec);
            Produto p2 = new Produto();
            
            Produto p3 = new Produto {
                Nome = "RADIO",
                Preco = 900.00,
                Quantidade = 3,
            };

            Produto p4 = new Produto() {
                Nome = "TV",
                Preco = 800.00,
                Quantidade = 0
            };

           
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
