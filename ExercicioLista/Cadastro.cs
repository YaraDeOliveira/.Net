using System.Globalization;

namespace ExercicioLista {
    class Cadastro {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get;private set; }

        public Cadastro(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalary(double percentage) {
            Salario += Salario * percentage / 100;
        }

        public override string ToString() {
            return Id
                   + ", "
                   + Nome
                   +", "
                   + Salario.ToString("F2", CultureInfo.InvariantCulture);
                   
        }
    }
}
