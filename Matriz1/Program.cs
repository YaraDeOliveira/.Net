using System;

namespace Matriz1 {
    class Program {
        static void Main(string[] args) {
            string[] dados = Console.ReadLine().Split(' ');
            int linha = int.Parse(dados[0]);
            int coluna = int.Parse(dados[1]);
            int[,] matriz = new int[linha, coluna];
            for (int c = 0; c < linha; c++) {
                dados = Console.ReadLine().Split();
                for (int j = 0; j < coluna; j++) {
                    matriz[c, j] = int.Parse(dados[j]);
                }
            }

            int localizar = int.Parse(Console.ReadLine());
            for (int c = 0; c < linha; c++) {
                for (int j = 0; j < coluna; j++) {
                    if (matriz[c, j] == localizar) {
                        Console.WriteLine($"Position {c}, {j}");
                        if (j != 0) {
                            Console.WriteLine($"Left: {matriz[c, j - 1]}");
                        }
                        if (j < coluna - 1) {
                            Console.WriteLine($"Right: {matriz[c, j + 1]}");
                        }
                        if (c != 0) {
                            Console.WriteLine($"Up: { matriz[c - 1, j]}");
                        }
                        if (c < linha - 1) {
                            Console.WriteLine($"Down: {matriz[c + 1, j]}");
                        }
                    }

                }

            }
        }
    }
}
