using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Student student1 = new Student("Денис", 12, 11.1);
            Student student2 = new Student("Нікіта", 11, 10.2);
            Student student3 = new Student("Рома", 10, 9.3);
            Student student4 = new Student("Назар", 9, 8.4);
            Student student5 = new Student("Антон", 8, 7.5);

            List<Student> students = new List<Student>()
            {
                student1, student2, student3, student4 , student5
            };

            Console.WriteLine("Студенти до фільтрування:");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Найвищий бал: {student.HighestMark}, Cереднiй бал: {student.AvgMark}");
            }

            Console.WriteLine();
            Console.WriteLine("Cтуденти після філтрування за найвищим балом:");

            var selectedByHighestMark = students.Where(x => x.HighestMark >= 10);
            foreach (var student in selectedByHighestMark)
            {
                Console.WriteLine($"{student.Name}, Найвищий бал: {student.HighestMark}, Cереднiй бал: {student.AvgMark}");
            }

            Console.WriteLine();
            Console.WriteLine("Cтуденти пілся фільтрування за cереднiм балом:");

            var selectedByAvgMark = students.Where(x => x.AvgMark >= 10);
            foreach (var student in selectedByAvgMark)
            {
                Console.WriteLine($"{student.Name}, Найвищий бал: {student.HighestMark}, Cереднiй бал: {student.AvgMark}");
            }
        }
    }
}