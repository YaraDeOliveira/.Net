using PedidosExercicio.Entities;
using PedidosExercicio.Entities.Enums;
using System;
using System.Globalization;

namespace PedidosExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client c1 = new Client(name, email, date);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus),Console.ReadLine());
            Order pedido = new Order(DateTime.Now,status, c1);
            Console.Write("How many items to this order?");
            int quant = int.Parse(Console.ReadLine());
            for (int c = 1; c <= quant; c++)
            {
                Console.WriteLine($"Enter #{c} item data:");
                Console.Write("Product name:");
                string nomeprod = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceprod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantprod = int.Parse(Console.ReadLine());
                Product product = new Product(nomeprod, priceprod);
                OrderItem order = new OrderItem(quantprod, product);
                pedido.AddItem(order);
            }
            Console.WriteLine(pedido);

        }
    }
}
