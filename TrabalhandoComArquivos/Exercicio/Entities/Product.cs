using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quant { get; set; }

        public Product(string name, double price, int quant)
        {
            Name = name;
            Price = price;
            Quant = quant;
        }
        public double Total()
        {
            return Price* Quant;
        }
    }
}
