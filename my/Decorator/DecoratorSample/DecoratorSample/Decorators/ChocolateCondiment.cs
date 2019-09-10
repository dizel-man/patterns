using DecoratorSample.Beverage;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DecoratorSample.Decorators
{
    class ChocolateCondiment: CondimentsDecoratorBase
    {

        private BevarageBase _bevarege;

        public ChocolateCondiment(BevarageBase bevarege)
        {
            _bevarege = bevarege;
            Description = _bevarege.GetDescription() + " + Chocolat";
        }

        public override double GetCost()
        {
            //  throw new NotImplementedException();
            return _bevarege.GetCost() + 70;
        }
    }
}
