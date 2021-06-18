using System;

namespace Intervalo {
    class Program {
        static void Main(string[] args) {
            double x = Double.Parse(Console.ReadLine());
            if (x >= 0 && x <= 25.0000) {
                Console.WriteLine("Intervalo [0,25]");
            } else if (x > 25.0000 && x <= 50.0000) {
                Console.WriteLine("Intervalo (25,50]");
            } else if (x > 50.000 && x <= 100.0000) {
                Console.WriteLine("Intervalo (75,100]");
            } else {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
