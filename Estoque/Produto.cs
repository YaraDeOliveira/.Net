using System.Globalization;

namespace Estoque {
    class Produto {
        public string Nome;
        public double Preço;
        public int Quantidade;


        public double ValorTotalEmEstoque() {
            return Preço * Quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preço.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
                
        }

        public void AdicionarProdutos(int quantity) {
            Quantidade = Quantidade + quantity;
            

        } 
        public void RemoverProdutos(int quantity) {
            Quantidade = Quantidade - quantity;

        }

    }
}
