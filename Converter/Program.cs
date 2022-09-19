using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Converter
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }
        
        private double _usd;
        private double _eur;
        private double _rub;

        private void Checker(string property, bool check, int value)

        {
            Console.WriteLine("Яку валюту ви хочете " + property + " usd/eur/rub ");


            string data = Console.ReadLine();
            switch (data)
            {
                case "usd":
                    if (check)
                    {
                        Console.WriteLine($"Конвертація з USD у UAH  = {_usd * value}");
                        break;
                    }

                    Console.WriteLine($"Конвертація з UAH у USD  = {value / _usd}");
                    break;

                case "eur":
                    if (check)
                    {
                        Console.WriteLine($"Конвертація з EUR у UAH  = {_eur * value}");
                        break;
                    }

                    Console.WriteLine($"Конвертація з UAH у EUR  = {value / _eur}");
                    break;

                case "rub":
                    if (check)
                    {
                        Console.WriteLine($"Конвертація з RUB у UAH  = {_rub * value}");
                        break;
                    }

                    Console.WriteLine($"Конвертація з UAH у RUB  = {value / _rub}");
                    break;

                
            }
        }

        public void ConvertToUah(int Currency)
        {
            Checker("Обміняти", true, Currency);

        }

        public void ConvertFromUah(int Currency)
        {
            Checker("Отримати", false, Currency);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Converter converter = new Converter(36.57, 36.51, 0.61);

            Console.WriteLine("Скільки UAH хочете обміняти?");
            converter.ConvertFromUah(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Напишіть сумму яку хочете обміняти");
            converter.ConvertToUah(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();

        }
    }
}