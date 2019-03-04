using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages.Decorators
{
    abstract class Decorator : BeverageManager
    {
        protected BeverageManager component;

        public Decorator(BeverageManager component)
        {
            this.component = component;
        }

        public override string Prepare(IBeverage b)
        {
            if (component != null)
            {
                return component.Prepare(b);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
