using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X + b.X, a.Y + b.Y);
        }

        public static Coordinate operator -(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X - b.X, a.Y - b.Y);
        }

        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }

    public class Program
    {
        public static void Main()
        {
            var c1 = new Coordinate(5, 7);
            var c2 = new Coordinate(2, 9);

            Console.WriteLine($"Точка c1: {c1}");
            Console.WriteLine($"Точка c2: {c2}");
            Console.WriteLine($"Результат сложения: {c1 + c2}");
            Console.WriteLine($"Результат вычитания: {c1 - c2}");
        }
    }
}