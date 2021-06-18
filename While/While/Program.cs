using System;
using System.Globalization;

namespace While {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0) {
                Console.WriteLine($"{Math.Sqrt(x):F3}");
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero Negativo!");
        }
    }
}
