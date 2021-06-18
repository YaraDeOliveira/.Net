namespace This {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto () {
            Quantidade = 10;
        }
          
       

        /* Usa-se this para referenciar um parametro como atributo,
         * Dessa forma, utiliza-se a letra maiuscula
         * e ao atribuir valor para a variavel, usa-se a palavra this*/
        public Produto (string Nome, double Preco) :this() {
            this.Nome = Nome;
            this.Preco = Preco;
            
        }
        
        public Produto (string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;


        }
        // Usa-se this tbm para referenciar outro construtor em um construtor
        /*public Produto() {
          Quantidade = 0;
        }
        public Produto(string nome, double preco) : this() {
        Nome = nome;
        Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this (nome, preco) {
        Quantidade = quantidade;
        }*/

}

}
