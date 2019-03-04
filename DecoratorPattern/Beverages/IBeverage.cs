using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    public interface IBeverage
    {
        int Volume { get; set; }
        int Temperatore { get; set; }
        Color MugColor { get; set; }
    }
}
