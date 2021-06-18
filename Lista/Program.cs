using System;
using System.Collections.Generic;

namespace Lista {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Ana");
            list.Add("Bob");
            list.Insert(2, "Marco");

            foreach (string nome in list) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("List.Count: " + list.Count);


            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro Indice com a letra A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo Indice com a letra A: " + pos2);
            Console.WriteLine();
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string nome in list2) {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            //list.RemoveAt(3);
            //list.RemoveRange(2, 2);
            foreach (string nome in list) {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            list.Remove("Alex");
            foreach (string nome in list) {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            list.RemoveAll(x => x[0] == 'M');
            foreach (string nome in list) {
                Console.WriteLine(nome);
            }


        } 


        // Exemplo de funcao qdo nao usar lambda
        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
}
