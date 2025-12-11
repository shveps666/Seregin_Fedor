using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5
{
    class Program
    {
        public class Time
        {
            private int hours;
            private int minutes;
            private int seconds;

            public Time(int h, int m, int s)
            {
                hours = h;
                minutes = m;
                seconds = s;
                Normalize();
            }
            public int this[int index]
            {
                get
                {
                    if (index == 0) return hours;
                    if (index == 1) return minutes;
                    if (index == 2) return seconds;
                    throw new IndexOutOfRangeException("Допустимые индексы: 0, 1, 2");
                }
                set
                {
                    if (index == 0) hours = value;
                    else if (index == 1) minutes = value;
                    else if (index == 2) seconds = value;
                    else throw new IndexOutOfRangeException("Допустимые индексы: 0, 1, 2");

                    Normalize();
                }
            }
            public static bool operator >(Time t1, Time t2)
            {
                if (t1.hours != t2.hours)
                    return t1.hours > t2.hours;
                if (t1.minutes != t2.minutes)
                    return t1.minutes > t2.minutes;
                return t1.seconds > t2.seconds;
            }

            public static bool operator <(Time t1, Time t2)
            {
                if (t1.hours != t2.hours)
                    return t1.hours < t2.hours;
                if (t1.minutes != t2.minutes)
                    return t1.minutes < t2.minutes;
                return t1.seconds < t2.seconds;
            }

            private void Normalize()
            {
                if (seconds >= 60)
                {
                    minutes += seconds / 60;
                    seconds %= 60;
                }
                if (minutes >= 60)
                {
                    hours += minutes / 60;
                    minutes %= 60;
                }

                if (seconds < 0)
                {
                    int borrow = (Math.Abs(seconds) + 59) / 60;
                    minutes -= borrow;
                    seconds += borrow * 60;
                }
                if (minutes < 0)
                {
                    int borrow = (Math.Abs(minutes) + 59) / 60;
                    hours -= borrow;
                    minutes += borrow * 60;
                }
            }

            public override string ToString()
            {
                return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
            }
        }
        static void Main()
        {
            var t1 = new Time(14, 35, 9);
            var t2 = new Time(9, 10, 5);

            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1[1]);

            t1[2] = 59;
            Console.WriteLine(t1);
        }
    }
}
