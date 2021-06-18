using System;

namespace DivididoXporY {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            for (int c = 0; c < N; c++) {
                string[] numeros = Console.ReadLine().Split();
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);
                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    double divisao = (double)x / y;
                    Console.WriteLine($"{divisao:f1}");
                  
                }

            }
        }
    }
}
