using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public Employee(string name, int salary, int experience)
        {
            Name = name;
            Salary = salary;
            Experience = experience;
        }
    }
}