//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DecoratorSample.Beverage
{


    class BlackTea : BevarageBase
    {
        public BlackTea()
        {
            Description = "Black tea from teabag";
        }


        public override double GetCost()
        {
            return 25;
        }
    }
}
