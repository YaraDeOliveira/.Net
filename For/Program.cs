using System;

namespace For {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int x = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= x; i++) {
                Console.Write("Valor #"+i+ ": ");
                int z = int.Parse(Console.ReadLine());
                soma += z;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
