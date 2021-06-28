using System;
using System.Linq;

namespace TreinandoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar o data source

            int[] numers = new int[] { 2, 3, 4, 5 };


            // Definir a consulta - query expression
            // Pegar todos os numeros pares e multiplica-los por 10
            var result = numers.Where(x => x % 2 == 0).Select(x => x *10);


            //Execute de query 
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }






            Console.WriteLine("Hello World!");
        }
    }
}
