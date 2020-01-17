using Helpers;
namespace operations
{
    public class Division
    {
        
        public static double Divide(int a, int b)
        {
            double c = a / b;
            return c;
        }

        public static double Divide(double a, double b)
        {
            double c = a / b;
            return Helpers.Rounding.RoundTwoDecimalPlaces(c);
        }
    }
}