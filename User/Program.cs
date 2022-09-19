using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace User
{
    internal class User
    {
        public User()
        {
            DateCompletion = DateTime.UtcNow;
        }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public DateTime DateCompletion { get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Login = "Klek";
            user.Name = "John";
            user.Surname = "Smith";
            user.Age = 23;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }

            Console.ReadLine();
        }
    }
}