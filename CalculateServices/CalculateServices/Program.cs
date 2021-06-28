using System;

namespace TesteCalculateServices
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.Max;
            double result = op.Invoke(a, b);

            //double result = CalculationServices.Max(a, b);
            Console.WriteLine(result);
        }
    }
}
