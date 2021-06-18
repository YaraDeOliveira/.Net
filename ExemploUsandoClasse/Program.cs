﻿using System;

namespace ExemploUsandoClasse {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX:f4}");
            Console.WriteLine($"Área de Y = {areaY:f4}");

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");

            } else {
                Console.WriteLine("Maior área: Y");
            }



        }
    }
}
