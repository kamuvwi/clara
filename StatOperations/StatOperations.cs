using System;
using operations;
using Helpers;

namespace StatOperations
{
    public class StatOperations
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = operations.Addition.Sum(values);
            var valueCount = Helpers.Array.ArrayLength(values);
            var result = operations.Division.Divide(sum, valueCount);
            return result;
        }
    }
}
