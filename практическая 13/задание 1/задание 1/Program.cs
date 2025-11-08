using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("Иван", 80000, DateTime.Now.AddYears(-2), 5);
            Developer d = new Developer("Петр", 60000, DateTime.Now.AddYears(-1), "C#");
            Director dir = new Director("Анна", 150000, DateTime.Now.AddYears(-5), "ИТ");

            Console.WriteLine("Информация о сотрудниках: ");
            m.DisplayInfo(); Console.WriteLine();
            d.DisplayInfo(); Console.WriteLine();
            dir.DisplayInfo(); Console.WriteLine();

            m.HoldMeeting();
            d.WriteCode();
            dir.ApproveBudget();

            Console.ReadLine();
        }
    }
}
