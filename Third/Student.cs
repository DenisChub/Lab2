using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Student
    {
        public string Name { get; set; }
        public int HighestMark { get; set; }
        public double AvgMark { get; set; }

        public Student(string name, int highestMark, double avgMark)
        {
            Name = name;
            HighestMark = highestMark;
            AvgMark = avgMark;
        }
    }
}