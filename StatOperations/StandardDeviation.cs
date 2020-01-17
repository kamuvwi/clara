using System;
using System.Collections.Generic;
using System.Text;
using Helpers;
using operations;

namespace StatOperations
{
    public class StandardDeviation
    {
        StatOperations statoperations = new StatOperations();
        public static dynamic StandardDev(dynamic values)
        {
            var mean = StatOperations.Mean(values);
            var variance = Variance.Variances(values, mean);
            var standiv = operations.Squarerooting.Squareroot(variance);
            //var valueCount = Helpers.Array.ArrayLength(values);

            return standiv; // to come and include the actual variable
        }

    }
}
