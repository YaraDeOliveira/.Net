using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostoDeRendaII.Entities
{
    abstract class Contribuinte
    {
        public double AnualIncome { get; set; }
        public string Name { get; set; }

        protected Contribuinte(double anualIncome, string name)
        {
            AnualIncome = anualIncome;
            Name = name;
        }

        public abstract double ImpostoDevido();
    }
}
