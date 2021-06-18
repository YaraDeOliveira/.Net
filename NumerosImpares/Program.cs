using System;

namespace NumerosImpares {
    class Program {
        static void Main(string[] args) {
            int z = int.Parse(Console.ReadLine());
            for (int c = 1; c <= z; c++) {
                if (c % 2 != 0) {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
