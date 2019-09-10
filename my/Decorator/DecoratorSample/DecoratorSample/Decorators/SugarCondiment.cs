using DecoratorSample.Beverage;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DecoratorSample.Decorators
{
    class SugarCondiment : CondimentsDecoratorBase

    {
        private BevarageBase _bevarege;

        public SugarCondiment(BevarageBase bevarege)
        {
            _bevarege = bevarege;
            Description = _bevarege.GetDescription() + " + Sugar";
        }

        public override double GetCost()
        {
            //  throw new NotImplementedException();
            return _bevarege.GetCost() + 10;
        }
    }
}
