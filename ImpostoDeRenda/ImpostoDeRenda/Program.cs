using System;

namespace ImpostoDeRenda {
    class Program {
        static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine());
            double apagar = 0;
            if (salario > 4500) {
                apagar = (salario - 4500) * 0.28;
                salario = 4500;
            }
            if (salario > 3000 && salario <= 4500) {
                apagar += (salario - 3000.01) * 0.18;
                salario = 3000;
            } 
            if (salario > 2000 && salario <= 3000) {
                apagar += (salario - 2000.01) * 0.08;
                salario = 2000;
            } if (salario >= 0 && salario <= 2000) { 
                apagar += 0;
            }
            if (apagar == 0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine($"R$ {apagar:F2}");
            }
        }
    }
}
