namespace Vetor2 {
    class Produto {
        public string Nome{ get; private set ; }
        public double Preco { get; private set; }

        public Produto (string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
}
