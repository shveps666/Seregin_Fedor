using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{

    public class SavingsAccount : Bank
    {
        public double InterestRate { get; set; } 

        public SavingsAccount(string accountNumber, string owner, decimal balance, double interestRate)
            : base(accountNumber, owner, balance)
        {
            InterestRate = interestRate;
        }
        public void AddInterest()
        {
            decimal interest = Balance * (decimal)(InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Начислены проценты: {interest}. Новый баланс: {Balance}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Процентная ставка: {InterestRate}%");
        }
    }
}
