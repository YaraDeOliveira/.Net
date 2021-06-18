using System;

namespace VetorExercicio {
    class Program {
        static void Main(string[] args) {
           
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());
            Cadastro[] vetor = new Cadastro[10];
            for (int c = 1; c <= N; c++) {
                Console.WriteLine("Aluguel #"+ c+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (vetor[quarto] == null) {
                    vetor[quarto] = new Cadastro(nome, email);
                }
            }
            Console.WriteLine("Quartos ocupados:");
            for (int d = 0; d < 10; d++) {
                if (vetor[d] != null) {
                    Console.WriteLine(d + ": " + vetor[d].Nome + ", " + vetor[d].Email);
                }
            }
        }
    }
}
