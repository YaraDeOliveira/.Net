using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PedidosExercicio.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }


        public OrderItem(int quantity, Product prod)
        {
            Quantity = quantity;
            Product = prod;
            Price = prod.Price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
