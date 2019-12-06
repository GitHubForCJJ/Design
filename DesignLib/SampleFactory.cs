using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignLib
{
    public class SampleFactory
    {
        public Calc GetOperation(string opt)
        {

            switch (opt)
            {
                case "+":
                    return new OperationAdd();

                case "-":
                    return new OperationSub();

                case "/":
                    return new OperationMult();

                default:
                    return new OperationAdd();

            }


        }
    }
}
