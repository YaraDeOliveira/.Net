using System;
using System.Globalization;

namespace Vetor2 {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            Produto[] vetor = new Produto[N];
            double soma = 0, media;
            for (int c = 0; c < N; c++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vetor[c] = new Produto (nome, preco);
                soma += vetor[c].Preco;
            }
            media = (double)soma / N;
            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
