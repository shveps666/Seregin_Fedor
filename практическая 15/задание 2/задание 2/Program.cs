using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зaдание_2
{
    internal interface ISwitchable
    {
        void On();
        void Off();
    }

    internal interface IAdjustable
    {
        void AdjustLevel(int value);
    }

    internal class Lamp : ISwitchable, IAdjustable
    {
        public int Brightness { get; private set; }
        public bool Powered { get; private set; }

        public void On()
        {
            Powered = true;
            Brightness = 100;
            Console.WriteLine($"Лампа включена. Яркость: {Brightness}%");
        }

        public void Off()
        {
            Powered = false;
            Brightness = 0;
            Console.WriteLine("Лампа выключена.");
        }

        public void AdjustLevel(int value)
        {
            if (value < 0) value = 0;
            if (value > 100) value = 100;

            Brightness = value;
            Console.WriteLine($"Яркость изменена на {Brightness}%");
        }
    }

    internal class Fan : ISwitchable
    {
        public void On()
        {
            Console.WriteLine("Вентилятор запущен.");
        }

        public void Off()
        {
            Console.WriteLine("Вентилятор остановлен.");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Lamp lamp = new Lamp();
            lamp.On();
            lamp.AdjustLevel(45);
            lamp.Off();

            Fan fan = new Fan();
            fan.On();
            fan.Off();
        }
    }
}

