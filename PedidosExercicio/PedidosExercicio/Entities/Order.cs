using PedidosExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PedidosExercicio.Entities
{
    public class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
     

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Orders.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Orders.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (OrderItem c in Orders)
            {
                soma += c.SubTotal();
            }
            return soma;
           
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status:" + Status);
            sb.Append("Client: " + Client.Name);
            sb.Append("(" + Client.BirthDate.ToString("dd/MM/yyyy") + ")");
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem c in Orders)
            {
                sb.Append(c.Product.Name);
                sb.Append(", $");
                sb.Append(c.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(c.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(c.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total Price: ");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();






        }

    }


}
