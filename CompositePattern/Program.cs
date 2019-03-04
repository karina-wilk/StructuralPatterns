using CompositePattern.Component;
using CompositePattern.Composite;
using CompositePattern.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Department devDept = new Department("Development Department");
            Department hrDept = new Department("Human Resources Department");

            IEmployee jKowalski = new Employee("Jan Kowalski", 5_000, 1_000, 200, 4);
            IEmployee aNowak = new Intern("Jan Kowalski", 1_200, 120);
            IEmployee wBialy = new Employee("Wojciech Biały", 6_000, 2_500, 340, 7);
            IEmployee kKsiazka = new Employee("Kamila Książka", 7_400, 0, 400, 1);

            devDept.AddWorker(jKowalski);
            devDept.AddWorker(aNowak);
            devDept.AddWorker(wBialy);
            devDept.AddWorker(kKsiazka);

            Console.WriteLine($"Avg salary in dept {devDept.Name} equals:\t{devDept.GetAvgSallary().ToString("0 000.00")}");

            IEmployee aCzerwony = new Employee("Andrzej Czerwony", 3_000, 300, 100, 12);
            IEmployee gKubik = new Intern("Grzegorz Kubik", 2_200, 0);
            IEmployee wKubik = new Intern("Wanda Kubik", 1_100, 0);
            IEmployee jBialy = new Employee("Jan Biały", 1_000, 2_500, 340, 7);
            IEmployee mEmpicka = new Employee("Maria Empicka", 8_200, 1233, 460, 12);

            hrDept.AddWorker(aCzerwony);
            hrDept.AddWorker(gKubik);
            hrDept.AddWorker(wKubik);
            hrDept.AddWorker(jBialy);
            hrDept.AddWorker(mEmpicka);

            Console.WriteLine($"Avg salary in dept {hrDept.Name} equals:\t{hrDept.GetAvgSallary().ToString("0 000.00")}");

            Console.Read();
        }
    }
}
