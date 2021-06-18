using System;
using System.Globalization;

namespace MembrosEstaticos2 {
    class Program {
        static void Main(string[] args) {
            Calculadora x = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = x.Circunferencia(raio);
            double volume = x.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + x.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}