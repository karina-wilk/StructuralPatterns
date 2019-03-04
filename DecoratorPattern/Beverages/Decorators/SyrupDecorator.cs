using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages.Decorators
{
    class SyrupDecorator : Decorator
    {
        public SyrupDecorator(BeverageManager comp) : base(comp)
        {
        }

        public override string Prepare(IBeverage b)
            => $"Added syrup.\n{base.Prepare(b)}";
    }
}
