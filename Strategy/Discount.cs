using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Discount : CashSuper
    {
        public double CountCondition { get; set; }
        public override double GetPayCount(double payAll)
        {
            return payAll * CountCondition;
        }
        public Discount(double countCondition)
        {
            CountCondition = countCondition;
        }
    }
}
