using System;

namespace MediasPonderadas {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            for (int c = 0; c < N; c++) {
                string[] x = Console.ReadLine().Split();
                double f = double.Parse(x[0]);
                double g = double.Parse(x[1]);
                double h = double.Parse(x[2]);
                double media = (f * 2 + g * 3 + h * 5) / 10;
                Console.WriteLine($"{media:F1}");
            }

        }
    }
}
