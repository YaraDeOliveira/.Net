using System;
using System.Collections.Generic;
using UsandoFunc.Entities;
using System.Linq;

namespace UsandoFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            // um metodo
            //Func<Product, string> func = NameUpper;
            //List<string> result2 = list.Select(func).ToList();
            //foreach (string s in result2)
            //{
            //    Console.WriteLine(s);
            //}

            //Lambda inline
            //List<string> result = list.Select(p => p.Name.ToUpper()).ToList();





            // Outro modo de fazer
            List<string> result = list.Select(NameUpper).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }

        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
