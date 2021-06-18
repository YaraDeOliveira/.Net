using System;

namespace SenhaFixa {
    class Program {
        static void Main(string[] args) {
            int senha = 2002;
            int x = int.Parse(Console.ReadLine());
            while (x != senha) {
                Console.WriteLine("Senha Invalida");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
