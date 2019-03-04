using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Component
{
    public interface IEmployee
    {
        string Name { get; set; }
        decimal GetAvgSallary();
    }
}
