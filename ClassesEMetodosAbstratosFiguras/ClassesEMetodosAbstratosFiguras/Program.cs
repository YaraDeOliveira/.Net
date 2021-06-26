using ClassesEMetodosAbstratosFiguras.Entities;
using System;
using System.Collections.Generic;
using ClassesEMetodosAbstratosFiguras.Enums;
using System.Globalization;
namespace ClassesEMetodosAbstratosFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lista = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int quan = int.Parse(Console.ReadLine());
            for (int d = 1; d <= quan; d++)
            {
                Console.WriteLine($"Shape #{d} data:" );
                Console.Write("Rectangle or Circle (r/c)? ");
                char x = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color),(Console.ReadLine()));
                if (x == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape obj in lista)
            {
                Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
