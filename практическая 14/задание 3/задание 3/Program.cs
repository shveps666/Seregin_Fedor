using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    public class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    public class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    public class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }
    class Program
    {
        static void Main()
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch)
            {
                f.Eat();
            }
        }
    }
}
