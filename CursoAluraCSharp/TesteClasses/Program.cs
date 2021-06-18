using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasses
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
        public int idade;
        public Endereco endereco;
    }

    public class Empresa
    {
        public string razaoSocial;
        public string cnpjs;
        public Endereco endereco;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pessoa guilherme = new Pessoa();
            guilherme.nome = "Guilherme";
            guilherme.endereco = new Endereco();
            guilherme.endereco.logradouro = "Avenida XYZ";
            Console.WriteLine(guilherme.endereco.logradouro);
            Console.ReadLine();
        }
    }
}
