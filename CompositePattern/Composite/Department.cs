using CompositePattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Composite
{
    public class Department : IEmployee
    {
        private List<IEmployee> workers = new List<IEmployee>();
        public string Name { get; set; }

        public Department(string name)
            => Name = name;

        public void AddWorker(IEmployee employee)
            => workers.Add(employee);

        public decimal GetAvgSallary()
        {
            decimal sumOfAvgSallary = 0;
            foreach(var e in workers)
            {
                sumOfAvgSallary += e.GetAvgSallary();
            }

            return workers.Count > 0 ? sumOfAvgSallary / workers.Count : 0;
        }
    }
}
