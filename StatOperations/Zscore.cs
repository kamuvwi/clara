using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations
{
    public class Zscore
    {
        public static double ZScore(dynamic score, dynamic mean, dynamic standiv)
        {
            dynamic zscore = Helpers.Rounding.RoundTwoDecimalPlaces(operations.Division.Divide((operations.Subtraction.Difference(score, mean)),standiv));
            return zscore;
        }
    }
}
