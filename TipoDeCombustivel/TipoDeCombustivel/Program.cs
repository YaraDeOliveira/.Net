using System;

namespace TipoDeCombustivel {
    class Program {
        static void Main(string[] args) {
            int cont1 = 0, cont2 =0 , cont3 = 0;
            int tipo = int.Parse(Console.ReadLine());
            while (tipo != 4) {
                tipo = int.Parse(Console.ReadLine());
                while (tipo < 0 | tipo > 4) {
                    tipo = int.Parse(Console.ReadLine());
                }
                if (tipo == 1) {
                    cont1 ++;
                } else if (tipo == 2) {
                    cont2 += 1;
                } else if (tipo == 3) {
                    cont3 += 1;
                }

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {cont1}");
            Console.WriteLine($"Gasolina: {cont2}");
            Console.WriteLine($"Diesel: {cont3}");
        }
    }
}
