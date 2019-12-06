using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class StrategyContext
    {
        CashSuper super = null;
        public void GetDiscount(string type)
        {
            switch (type)
            {
                case "满300减80":
                    super = new FullReduce(300, 80);
                    break;
                case "normal":
                    super = new Discount(1);
                    break;
                case "8折":
                    super = new Discount(0.8);
                    break;
            }
        }
        public double GetResult(double allmonry)
        {
            return super.GetPayCount(allmonry);
        }
    }
}
