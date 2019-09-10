//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DecoratorSample.Beverage
{
    class GreenTea : BevarageBase
    {

        public GreenTea()
        {
            Description = "Green leaf tea from teabag";
        }


        public override double GetCost()
        {
            return 125;
        }
    }
}
