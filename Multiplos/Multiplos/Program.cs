using System;

namespace Multiplos {
    class Program {
        static void Main(string[] args) {
            string[] x = Console.ReadLine().Split();
            int A = int.Parse(x [0]);
            int B = int.Parse(x [1]);
            if (B % A == 0 || A % B == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }


        }
    }
}
