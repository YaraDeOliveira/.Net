using CadastroFuncionarioExercicio.Entities.Enum;
using System;
using System.Globalization;
using CadastroFuncionarioExercicio.Entities;

namespace CadastroFuncionarioExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento depto = new Departamento();
            Console.Write("Entre com o nome do departamento: ");
            depto.Nome = Console.ReadLine();
            Console.WriteLine("Entre com os dados do funcionario: ");
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Name = Console.ReadLine();
            Console.Write("Nivel (Junior/MidLevel/Senior): ");
            func.Nivel = (Classificacao)Enum.Parse(typeof(Classificacao),Console.ReadLine());
            Console.Write("Base Salarial: ");
            func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            func.departamento = depto;
            Console.Write("Quantos contratos para esse trabalhador: ");
            int quant = int.Parse(Console.ReadLine());
            for (int c = 1; c <= quant; c++)
            {
                Console.WriteLine($"Entre com os dados do contrato {c}");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duracao do contrato em horas:  ");
                int duracao = int.Parse(Console.ReadLine());
                ContratoHora contrato = new ContratoHora(data,valor,duracao);
                func.AdicionarContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e ano que você quer calcular os ganhos (MM/AAAA): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome : " + func.Name);
            Console.WriteLine("Departmento: " + func.departamento.Nome);
            Console.WriteLine("Ganhos em " + monthAndYear + ": " + func.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}


