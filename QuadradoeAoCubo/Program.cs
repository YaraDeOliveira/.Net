using System;

namespace QuadradoeAoCubo {
    class Program {
        static void Main(string[] args) {
            int total = 1;
            int N = int.Parse(Console.ReadLine());
            for(int c = 1; c <= N; c++) {
                for (int d = 1; d <= 3; d++) {
                    total *= c;
                    if (d != 3) {
                        Console.Write(total.ToString() + ' ');
                    }
                    else {
                        Console.Write(total.ToString());
                    }
                }
            Console.WriteLine();
            total = 1;
            }
        }
    }
}
