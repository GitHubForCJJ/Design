using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignLib
{
    public abstract class Calc
    {
        public string NumberA { get; set; }
        public string NumberB { get; set; }

        public abstract Double GetResult();
    }
}
