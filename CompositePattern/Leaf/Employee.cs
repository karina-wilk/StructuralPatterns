using CompositePattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Leaf
{
    public class Employee : IEmployee
    {
        public Employee(string name, decimal salary, decimal hbonus, decimal recompenseForDayOff, int numerOfDaysOffLeft)
        {
            Name = name;
            SalaryPerMonth = salary;
            HolidayBonus = hbonus;
            RecompenseForDayOff = recompenseForDayOff;
            NumerOfDaysOffLeft = numerOfDaysOffLeft;
        }

        public string Name { get; set; }

        private decimal SalaryPerMonth { get; set; }
        private decimal HolidayBonus { get; set; }
        private decimal RecompenseForDayOff { get; set; }
        private int NumerOfDaysOffLeft{ get; set; } 

        public decimal GetAvgSallary()
            => (SalaryPerMonth * 12 + HolidayBonus + RecompenseForDayOff * NumerOfDaysOffLeft) / 12;
    }
}
