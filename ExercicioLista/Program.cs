using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos funcionarios serão registrados? ");
            int quant = int.Parse(Console.ReadLine());
            List<Cadastro> funcionarios = new List<Cadastro>();
            for (int d = 1; d <= quant; d++) {
                Console.WriteLine("Funcionário #" + d + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Cadastro(id, nome, salario));
                Console.WriteLine();
            }
            Console.Write("Entre com o Id do funcionário que você quer aumentar o salário: ");
            int idaumento = int.Parse(Console.ReadLine());

            Cadastro emp = funcionarios.Find(x => x.Id == idaumento);
            if (emp == null) {
                Console.WriteLine("Esse id não existe!");
            } else {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios: ");
            foreach (Cadastro obj in funcionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}
