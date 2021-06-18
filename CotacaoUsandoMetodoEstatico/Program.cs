using System;
using System.Globalization;

namespace CotacaoUsandoMetodoEstatico {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Moeda(cot, qtde).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
