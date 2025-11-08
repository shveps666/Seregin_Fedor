using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    public class ObjectCounter
    {
        private static int count = 0;

        public ObjectCounter()
        {
            count++;
        }
        public static void ShowCount()
        {
            Console.WriteLine($"Текущее количество объектов: {count}");
        }
    }
    class Program
    {
        static void Main()
        {
            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter obj3 = new ObjectCounter();
            ObjectCounter.ShowCount();
        }
    }
}
