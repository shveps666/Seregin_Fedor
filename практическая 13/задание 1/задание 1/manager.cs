using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, DateTime hireDate, int teamSize)
            : base(name, "Менеджер", salary, hireDate)
        {
            TeamSize = teamSize;
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} проводит собрание с командой ({TeamSize} человек).");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размер команды: {TeamSize}");
        }
    }
}
