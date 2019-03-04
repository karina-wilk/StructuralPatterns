using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    public class CoffeeManager: BeverageManager
    {
        public override string Prepare(IBeverage c)
            => $"I poured {c.Volume}ml of black coffee to the mug!";
    }
}
