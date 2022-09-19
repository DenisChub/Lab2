using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Address
{
    internal class Address
    {
        private int _index;
        private string _city;
        private string _country;
        private string _street;
        private string _house;
        private string _apartment;

        public int Index { get { return _index; } set { _index = value; } }

        public string City { get { return _city; } set { _city = value; } }

        public string Country { get { return _country; } set { _country = value; } }

        public string Street { get { return _street; } set { _street = value; } }

        public string House { get { return _house; } set { _house = value; } }

        public string Apartment { get { return _apartment; } set { _apartment = value; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Apartment = "three-room";
            address.Country = "Ukraine";
            address.Street = "Lisova";
            address.House = "11";
            address.City = "Kyiv";
            address.Index = 1;

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            }

            Console.ReadLine();
        }
    }
}