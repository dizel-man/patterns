using DecoratorSample.Beverage;
using DecoratorSample.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {

            BevarageBase espresso = new Espresso();
            BevarageBase blackTea = new BlackTea();
            BevarageBase greenTea = new GreenTea();

            PrintBeverage(espresso);
            PrintBeverage(blackTea);
            PrintBeverage(greenTea);
             

            Console.WriteLine("----------");


            BevarageBase capuccino = new SugarCondiment(new MilkCondiment(new Espresso()));
          
            PrintBeverage(capuccino);


            BevarageBase greenTeaWithSugar = new SugarCondiment(new GreenTea());

            PrintBeverage(greenTeaWithSugar);


            Console.ReadKey();

        }

        static void PrintBeverage(BevarageBase baverage)
        {

            Console.WriteLine("Bevarage: {0}; Price: {1}", baverage.GetDescription(), baverage.GetCost());
        }
    }
}
