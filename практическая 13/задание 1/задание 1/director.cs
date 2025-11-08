using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, decimal salary, DateTime hireDate, string department)
            : base(name, "Директор", salary, hireDate)
        {
            Department = department;
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утвердил бюджет отдела: {Department}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Отдел: {Department}");
        }
    }
}
