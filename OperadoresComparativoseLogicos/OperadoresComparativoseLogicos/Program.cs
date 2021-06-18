using System;

namespace OperadoresComparativoseLogicos {
    class Program {
        static void Main(string[] args) {
            /*int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("-----------------");*/

            bool d1 = 2 > 3 && 4 != 5; 
            // Console.WriteLine(d1);
            bool d2 = 2 > 3 ||  4 != 5; // verdadeiro
            //Console.WriteLine(d2);
            bool d3 = !(2 > 3) && 4 != 5; // verdadeiro
            //Console.WriteLine(d3);
            Console.WriteLine("-----------------");
            bool d4 = 10 < 5; // falso
            bool d5 = d2 || d3 && d4;
            Console.WriteLine(d5);
        }
    }
}
