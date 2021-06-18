using System;

namespace ExerciciosIfElse {
    class Program {
        static void Main(string[] args) {
            /*int x = int.Parse(Console.ReadLine());
            if (x < 0) {
                Console.WriteLine("NEGATIVO");
            } else {
                Console.WriteLine("NAO NEGATIVO");
            }*/

            int y = int.Parse(Console.ReadLine());
            if (y % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }

        }
    }
}
