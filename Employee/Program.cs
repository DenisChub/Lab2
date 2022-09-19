using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Employee
{
    public class Employee
    {
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
            Random random = new Random();
            _experience = random.Next(0, 30);
            Position = (Position)random.Next(0, 3);

            if (_experience > 10)
            {
                _salary = _salary + 10000;
            }

            if (Position == (Position)2)
            {
                _salary = _salary + 20000;
            }
        }

        public string _name;
        public string _surname;
        public int _experience;
        public int _salary = 12000;
        public int _tax;

        public Position Position { get; set; }

        public int Salary { get { return _salary; } }

        public int Tax
        {
            get
            {
                if (Salary >= 15000)
                {
                    _tax = _salary / 12;
                }
                else
                {
                    _tax = Salary / 10;
                }
                return _tax;
            }
        }
        
    }
    public enum Position
    {
        Junior = 0,
        Middle = 1,
        Senior = 2,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Smith");
            Console.WriteLine($"{employee._name} {employee._surname} {employee._experience} {employee.Position} {employee.Tax} {employee.Salary}");
            Console.ReadLine();
        }
    }
}