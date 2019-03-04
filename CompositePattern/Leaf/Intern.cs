using CompositePattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Leaf
{
    public class Intern : IEmployee
    {
        public Intern(string name, decimal salary, decimal bonus)
        {
            Name = name;
            SalaryPerMonth = salary;
            Bonus = bonus;
        }

        public string Name { get; set; }

        private decimal SalaryPerMonth { get; set; }
        private decimal Bonus { get; set; }

        public decimal GetAvgSallary()
            => (SalaryPerMonth * 12 + Bonus) / 12;
    }
}
