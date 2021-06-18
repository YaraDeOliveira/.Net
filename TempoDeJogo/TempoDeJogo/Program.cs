using System;

namespace TempoDeJogo {
    class Program {
        static void Main(string[] args) {
            int duracao = 0; 
            string[] x = Console.ReadLine().Split();
            int inicio = int.Parse(x[0]);
            int fim = int.Parse(x[1]);
            if (inicio == fim) {
                duracao = 24;
            } else if (fim > inicio) {
                duracao = fim - inicio;
            } else {
                duracao = 24 - inicio + fim;
            }
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}
