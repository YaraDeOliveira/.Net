using System;
using System.Globalization;

namespace ControleNotas {
    class Program {
        static void Main(string[] args) {
            Aluno x = new Aluno();
            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            x.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notafim = x.NFinal();
            Console.WriteLine("NOTA FINAL = " + notafim.ToString("F2", CultureInfo.InvariantCulture));
            
            if (x.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                    + x.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
                    
            }
        }
    }
}
