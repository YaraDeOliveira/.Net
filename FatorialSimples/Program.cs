using System;

namespace FatorialSimples {
    class Program {
        static void Main(string[] args) {
            int total = 1;
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {
                total *= (N - i);
            }
            Console.WriteLine(total);
        }
    }
}
