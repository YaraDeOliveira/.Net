using System;
using System.Globalization;

namespace CadastroSalarioFuncionario {
    class Program {
        static void Main(string[] args) {
            Funcionario x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + x);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(porcento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);


        }
    }
}
