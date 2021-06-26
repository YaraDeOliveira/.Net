using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostoDeRendaII.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica(double anualIncome, string name, double healthExpenditures)
            : base(anualIncome, name)
        {
            HealthExpenditures = healthExpenditures;
        }

        public double ValorAAbater()
        {
            return HealthExpenditures * 0.50;
        }

        public override double ImpostoDevido()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - ValorAAbater();
            }
            else
            {
                return (AnualIncome * 0.25) - ValorAAbater();
            }
        }
    }


}
