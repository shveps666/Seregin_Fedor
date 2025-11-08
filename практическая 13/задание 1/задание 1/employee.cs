using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string position, decimal salary, DateTime hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Зарплата: {Salary}");
            Console.WriteLine($"Дата приема: {HireDate.ToShortDateString()}");
        }
    }
}
