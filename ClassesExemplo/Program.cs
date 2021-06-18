using System;

namespace ClassesExemplo {
    class Program {
        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Fabio";
            pessoa1.idade = 32;
            pessoa1.genero = "Masculino";

            pessoa1.Identificar();

            Pessoa pessoa2 = new Pessoa("Amanda", 44, "feminino");
            pessoa2.Identificar();
            

          
        }
    }
}
