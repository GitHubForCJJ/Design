using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignLib
{
    public class OperationAdd : Calc
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
        //public OperationAdd(double a,double b)
        //{
        //    NumberA = a;
        //    NumberB = b;
        //}
    }
}
