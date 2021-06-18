namespace CotacaoUsandoMetodoEstatico {
    class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double Moeda (double cotacao, double qtde) {
            double totalsemimposto = cotacao * qtde;
            return totalsemimposto + (totalsemimposto * (Iof / 100));

        }
    }
}
