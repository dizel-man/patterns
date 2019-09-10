//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using DecoratorSample.Beverage;

namespace DecoratorSample.Decorators
{
    class MilkCondiment : CondimentsDecoratorBase
    {
        private BevarageBase _bevarege;

        public MilkCondiment(BevarageBase bevarege)
        {
            _bevarege = bevarege;
            Description = _bevarege.GetDescription() + " + Milk";
        }

        public override double GetCost()
        {
            //  throw new NotImplementedException();
            return _bevarege.GetCost() + 50;
        }
    }
}
