using System;

namespace operations
{
    public class Squarerooting
    {
        public static double Squareroot(int a)
        {
            return Math.Sqrt(a);
        }

        public static double Squareroot(double a)
        {
            return Helpers.Rounding.RoundTwoDecimalPlaces(Math.Sqrt(a));
        }
    }
}