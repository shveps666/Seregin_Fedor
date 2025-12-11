using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    public class Money
    {
        public int Rub { get; set; }
        public int Kop { get; set; }

        public Money(int rub, int kop)
        {
            Rub = rub;
            Kop = kop;
            Normalize();
        }
        public static Money operator +(Money a, Money b)
        {
            int totalKop = a.Kop + b.Kop;
            int totalRub = a.Rub + b.Rub + totalKop / 100;
            totalKop %= 100;
            return new Money(totalRub, totalKop);
        }
        public static bool operator ==(Money a, Money b)
        {
            return a.Rub == b.Rub && a.Kop == b.Kop;
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
        private void Normalize()
        {
            if (Kop >= 100)
            {
                Rub += Kop / 100;
                Kop %= 100;
            }
            else if (Kop < 0)
            {
                int borrow = (Math.Abs(Kop) + 99) / 100;
                Rub -= borrow;
                Kop += borrow * 100;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Money other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return Rub * 100 + Kop;
        }

        public override string ToString()
        {
            return $"{Rub} руб {Kop} коп";
        }
    }
    class Program
    {
        static void Main()
        {
            var m1 = new Money(10, 50);
            var m2 = new Money(5, 75);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 == new Money(10, 50));
        }
    }
}
