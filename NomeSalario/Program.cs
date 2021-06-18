using System;

namespace NomeSalario {
    class Program {
        static void Main(string[] args) {
            Funcionario primeiro, segundo;
            primeiro = new Funcionario();
            segundo = new Funcionario();
            
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            primeiro.nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiro.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            segundo.nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundo.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (double)(primeiro.salario + segundo.salario) / 2;
            Console.Write("Salário médio = " + salarioMedio.ToString("F2"));

        }
    }
}
