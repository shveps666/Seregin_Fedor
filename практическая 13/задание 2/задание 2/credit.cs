using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{

    public class Credit : Bank
    {
        public decimal CreditLimit { get; set; }    
        public DateTime RepaymentDate { get; set; } 

        public Credit(string accountNumber, string owner, decimal balance, decimal creditLimit, DateTime repaymentDate)
            : base(accountNumber, owner, balance)
        {
            CreditLimit = creditLimit;
            RepaymentDate = repaymentDate;
        }

        public void MakePayment(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Платеж {amount} выполнен. Остаток долга: {Balance}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кредитный лимит: {CreditLimit}, Дата погашения: {RepaymentDate.ToShortDateString()}");
        }
    }
}
