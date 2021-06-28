
namespace TesteCalculateServices
{
    public class CalculationServices
    {
        // se (x >  y) retorna x, senao retorna y (condicao ternaria)
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }

    }
}
