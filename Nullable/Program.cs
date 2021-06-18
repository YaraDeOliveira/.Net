using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {
            // nao é possivel atribir valor nulo diretamente
            //double x = null;

            //Nullable<double> x = null;
            // ou

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("X é null");
            }

            Console.WriteLine(y.Value);



            double? d = null;
            double? e = 10;

            double a = d ?? 5;
            double b = e ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
