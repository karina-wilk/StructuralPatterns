using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    public abstract class BeverageManager
    {
        public abstract string Prepare(IBeverage b);
    }
}
