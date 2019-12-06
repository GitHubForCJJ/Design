using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignLib
{
    public class OperationSub : Calc
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
        //public OperationSub(double a, double b)
        //{
        //    NumberA = a;
        //    NumberB = b;
        //}
    }
}
