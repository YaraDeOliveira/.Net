using System;
using System.Globalization;

namespace DateTimeExemplo {
    class Program {
        static void Main(string[] args) {

            /*DateTime d2 = DateTime.Now;
            Console.WriteLine(d2);
            Console.WriteLine(d1.Ticks);
            */

            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2021, 06, 20, 20, 45, 03);
            DateTime d3 = new DateTime(2021, 06, 20, 20, 45, 03, 500);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            DateTime data = DateTime.Parse("2000-08-15");
            DateTime datahor = DateTime.Parse("2000-08-15 13:05:58");
            DateTime databrasil = DateTime.Parse("15/08/2000");
            DateTime datahorabrasil = DateTime.Parse("15/08/2000 13:01:57");


            DateTime e1 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime e2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(data);
            Console.WriteLine(datahor); 
            Console.WriteLine(databrasil);
            Console.WriteLine(datahorabrasil);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
        
    }
}
