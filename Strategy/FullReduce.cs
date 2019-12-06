using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FullReduce : CashSuper
    {
        public double ConditionMoney { get; set; }
        public double PayReturn { get; set; }
        public override double GetPayCount(double payAll)
        {
            return payAll - (payAll / ConditionMoney) * PayReturn;
        }
        public FullReduce(double conditon, double payreturn)
        {
            ConditionMoney = conditon;
            PayReturn = payreturn;
        }
    }
}
