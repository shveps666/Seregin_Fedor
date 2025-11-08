using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace задание_1
{
    public class Developer : Employee
    {
        public string Language { get; set; }

        public Developer(string name, decimal salary, DateTime hireDate, string language)
            : base(name, "Разработчик", salary, hireDate)
        {
            Language = language;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} пишет код на {Language}...");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Язык программирования: {Language}");
        }
    }
}
