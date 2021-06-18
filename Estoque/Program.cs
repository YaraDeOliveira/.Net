using System;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {

            Produto x = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Dados do Produto: " + x);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            x.RemoverProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);
        }
    }
}
