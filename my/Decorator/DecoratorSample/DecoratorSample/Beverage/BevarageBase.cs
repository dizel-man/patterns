//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DecoratorSample.Beverage
{
   public abstract class BevarageBase
    {
        protected string Description = "";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
