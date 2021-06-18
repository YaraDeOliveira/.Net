using System;

namespace Intervalo2 {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            int countin = 0, countout = 0;
            for (int c = 0; c < N; c++) {
                int X = int.Parse(Console.ReadLine());
                if (X >=10 && X <= 20) {
                    countin += 1;
                }
                else {
                    countout += 1;
                }
            }
            Console.WriteLine(countin + " in");
            Console.WriteLine(countout + " out");
        }
    }
}
