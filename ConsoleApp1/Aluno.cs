namespace ControleNotas {
    class Aluno {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NFinal() {
            return N1 + N2 + N3;
            
        }
        public bool Aprovado() {
            if (NFinal() >= 60.0 ) {
                return true;
            } else {
                return false;
            }
        }

        public double NotaRestante() {
            if (Aprovado()) {
                return 0.00;
            } else {
                return 60.00 - NFinal();
            }
        }
    }
}
