using System;
using System.Globalization;
using LocadoraCarros.Entities;
using LocadoraCarros.Services;

namespace LocadoraCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string car = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickup = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime retur = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceday = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(pickup, retur, new Vehicle(car));
            RentalServices rentalServices = new RentalServices(pricehour, priceday, new BrazilTaxServices());

            rentalServices.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice);


        }
    }
}
