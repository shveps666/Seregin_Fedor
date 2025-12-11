using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_Изменённое
{
    internal interface ICostable
    {
        double GetCost();
    }
    internal interface IWarrantyInfo
    {
        int WarrantyPeriod();
    }
    internal class Smartphone : ICostable, IWarrantyInfo
    {
        private double price;
        private int months;

        public Smartphone(double price, int months)
        {
            price = price;
            months = months;
        }

        public double GetCost()
        {
            return price;
        }

        public int WarrantyPeriod()
        {
            return months;
        }
    }

    internal class Notebook : ICostable
    {
        private double price;

        public Notebook(double price)
        {
            price = price;
        }

        public double GetCost()
        {
            return price;
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var items = new List<object>
            {
                new Smartphone(55000, 36),
                new Notebook(72000),
                new Smartphone(32000, 12),
                new Notebook(46000)
            };

            double total = 0;

            foreach (var item in items)
            {
                if (item is ICostable cost)
                {
                    double current = cost.GetCost();
                    total += current;

                    Console.WriteLine($"Текущая цена изделия: {current} руб.");

                    if (item is IWarrantyInfo warranty)
                    {
                        Console.WriteLine($"Гарантийный срок: {warranty.WarrantyPeriod()} мес.");
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Суммарная стоимость всех позиций: {total} руб.");
        }
    }
}
