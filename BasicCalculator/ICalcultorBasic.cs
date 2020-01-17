using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface ICalcultorBasic
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Difference(dynamic a, dynamic b);
        public dynamic Multiply(dynamic a, dynamic b);
        public dynamic Square(dynamic a);
        public dynamic Cubed(dynamic a);
        public dynamic Squareroot(dynamic a);

    }
}
