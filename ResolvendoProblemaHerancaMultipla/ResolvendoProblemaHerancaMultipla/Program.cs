using ResolvendoProblemaHerancaMultipla.Devices;
using System;

namespace ResolvendoProblemaHerancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My Letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice x = new ComboDevice() { SerialNumber = 3921 };
            x.ProcessDoc("My dissertation");
            x.Print("My dissertation");
            Console.WriteLine(x.Scan());
        }
    }
}
