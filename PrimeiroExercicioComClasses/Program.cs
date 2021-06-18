using System;

namespace PrimeiroExercicioComClasses {
    class Program {
        static void Main(string[] args) {
            Pessoa um, dois;
            um = new Pessoa();
            dois = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            um.nome = Console.ReadLine();
            Console.Write("Idade: ");
            um.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            dois.nome = Console.ReadLine();
            Console.Write("Idade: ");
            dois.idade = int.Parse(Console.ReadLine());
            if (um.idade > dois.idade) {
                Console.WriteLine("Pessoa mais velha: " + um.nome);

            } else {
                Console.WriteLine("Pessoa mais velha: " + dois.nome);
            }
        }
    }
}
