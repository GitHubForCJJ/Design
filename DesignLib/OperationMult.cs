using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignLib
{
    public class OperationMult : Calc
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
        //public OperationMult(double a, double b)
        //{
        //    NumberA = a;
        //    NumberB = b;
        //}
    }

}
