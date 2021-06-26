using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostoDeRendaII.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica(double anualIncome, string name, int numberOfEmployees)
            : base (anualIncome, name) 
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double ImpostoDevido()
        {
            if (NumberOfEmployees > 10)
                return AnualIncome * 0.14;
            else
                return AnualIncome * 0.16;
        }
    }
}
