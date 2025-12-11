using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4
{
    class Program
    {
        public class Vector
        {
            private double[] elements;

            public Vector(params double[] values)
            {
                elements = values;
            }
            public double this[int index]
            {
                get => elements[index];
                set => elements[index] = value;
            }

            public int Length => elements.Length;
            public static double operator *(Vector a, Vector b)
            {
                if (a.Length != b.Length)
                    throw new ArgumentException("Размеры векторов должны совпадать");

                double result = 0;
                for (int i = 0; i < a.Length; i++)
                    result += a[i] * b[i];

                return result;
            }

            public override string ToString()
            {
                return $"[{string.Join(", ", elements)}]";
            }
        }
        static void Main()
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);

            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);
        }
    }
}
