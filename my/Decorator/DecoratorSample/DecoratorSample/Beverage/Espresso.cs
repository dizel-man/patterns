//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DecoratorSample.Beverage
{
    class Espresso : BevarageBase
    {

        public Espresso()
        {
            Description = "Small portion of strong coffee";
        }

        public override double GetCost()
        {
            return 150;
        }
    }
}