using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    public class check : Bank
    {
        public decimal OverdraftLimit { get; set; } 


        public check(string accountNumber, string owner, decimal balance, decimal overdraftLimit)
            : base(accountNumber, owner, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount}. Баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Превышен лимит овердрафта");
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Лимит овердрафта: {OverdraftLimit}");
        }
    }
}
