using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages.Decorators
{
    class MilkDecorator : Decorator
    {
        public MilkDecorator(BeverageManager comp) : base(comp)
        {
        }

        public override string Prepare(IBeverage b)
            => $"Add steamed milk.\n{base.Prepare(b)}";
    }
}
