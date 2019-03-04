using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    public class Coffee : IBeverage
    {
        public int Volume { get; set; }
        public int Temperatore { get; set; }
        public Color MugColor { get; set; }
    }
}
