using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Product product1 = new Product("Помідори", "Овочі", 62);
            Product product2 = new Product("Хлiб", "Випічка", 34);
            Product product3 = new Product("Кефір", "Молочнi продукти", 78);
            Product product4 = new Product("М'ясо", "М'яснi продукти", 92);
            Product product5 = new Product("Бананм", "Фрукти", 55);
            Product product6 = new Product("Ківі", "Фрукти", 32);

            List<Product> products = new List<Product>()
            { product1, product2, product3, product4, product5, product6};

            Console.WriteLine("Продукти: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, категорiя: {product.Category}, цiна: {product.Price} грн");
            }

            Console.WriteLine();
            Console.WriteLine("Групування за категорiями: ");

            var selectedByCategory = products.GroupBy(x => x.Category).ToList();
            foreach (var category in selectedByCategory)
            {
                Console.WriteLine($"{category.Key}:");

                foreach (var product in category)
                {
                    Console.WriteLine($"{product.Name}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Групування за цiнами:");

            var selectedByPrice = products.GroupBy(x => x.Price).ToList();
            foreach (var price in selectedByPrice)
            {
                Console.WriteLine($"{price.Key} грн:");

                foreach (var product in price)
                {
                    Console.WriteLine($"{product.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}