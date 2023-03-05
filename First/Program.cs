using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Employee employee1 = new Employee("Працiвник 1", 1111, 1);
            Employee employee2 = new Employee("Працiвник 2", 2222, 2);
            Employee employee3 = new Employee("Працiвник 3", 3333, 3);
            Employee employee4 = new Employee("Працiвник 4", 4444, 4);
            Employee employee5 = new Employee("Працiвник 5", 5555, 5);
            Employee employee6 = new Employee("Працiвник 6", 6666, 6);

            List<Employee> employees = new List<Employee>()
            { employee1, employee2, employee3, employee4, employee5, employee6};
            Console.WriteLine("Несортованнi робiтники: ");

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}, роки досвiду: {employee.Experience}");
            }

            Console.WriteLine();
            Console.WriteLine("Сортування за зарплатою:");

            var selectedBySalary = employees.OrderByDescending(x => x.Salary).ThenBy(x => x.Salary).ToList();
            foreach (var employee in selectedBySalary)
            {
                Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}, роки досвiду: {employee.Experience}");
            }

            Console.WriteLine();
            Console.WriteLine("Сортування за роками досвiду:");

            var selectedByExperience = employees.OrderByDescending(x => x.Experience).ThenBy(x => x.Experience).ToList();
            foreach (var employee in selectedByExperience)
            {
                Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}, роки досвiду: {employee.Experience}");
            }

            Console.ReadLine();
        }
    }
}