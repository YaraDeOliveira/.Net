using System;
using System.Collections.Generic;

namespace Matriz2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);




            /*int cont = 0;
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];
            List<int> diagonal = new List<int>(); 
            for (int c = 0; c < N; c++) {
                string[] listaEntrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[c, j] = int.Parse(listaEntrada[j]);
                    if (mat[c, j] < 0) {
                        cont += 1;
                    }
                    if (c == j) {
                        diagonal.Add(mat[c, j]);     
                    }
                }
            }
            Console.WriteLine("Main diagonal:");
            for (int l = 0; l < N; l++) {
                if (l < N-1) {
                    Console.Write(diagonal[l] + " ");
                } else {
                    Console.WriteLine(diagonal[l]);
                }
     
            }
            
            Console.WriteLine("Negative numbers = " + cont);
            */





        }
    }
}
