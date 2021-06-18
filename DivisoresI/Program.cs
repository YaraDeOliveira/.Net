using System;

namespace DivisoresI {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            for (int c = 1; c <= N; c++) {
                if (N % c == 0) {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
