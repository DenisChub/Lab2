using System;
using System.Collections.Generic;

namespace Fourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            List<string> strings = new List<string>() { "один", "два", "три", "чотири", "п'ять" };

            Func<string, int> stringLengthDelegate = s => s.Length;

            foreach (var str in strings)
            {
                int length = stringLengthDelegate(str);
                Console.WriteLine($"{str}: {length}");
            }
        }
    }
}