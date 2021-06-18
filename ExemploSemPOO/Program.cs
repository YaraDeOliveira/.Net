using System;

namespace ExemploSemPOO {
    class Program {
        static void Main(string[] args) {
            char maior;
            Console.WriteLine("Entre com as medidas do Triangulo X:");
            double AreaX = AreaTriangulo();
            Console.WriteLine("Entre com as medidas do Triangulo Y:");
            double AreaY = AreaTriangulo();
            Console.WriteLine($"Área de X = {AreaX:f4}");
            Console.WriteLine($"Área de Y = {AreaY:f4}");
            if (AreaX > AreaY) {
                maior = 'X';
            } else {
                maior = 'Y';
            }
            Console.WriteLine("Maior área: " + maior);

        }
        public static double AreaTriangulo() {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
    
}
