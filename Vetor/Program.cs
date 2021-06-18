using System;
using System.Globalization;

namespace Vetor {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            double[] vetor = new double [N];
            double soma = 0, media;
            for (int c = 0; c < N; c++) {
                vetor[c] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vetor[c];
            }
            media = (double)soma / N;
            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
