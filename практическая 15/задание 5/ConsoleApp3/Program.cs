using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_Вариант
{
    namespace Banking
    {
        interface IDepositable
        {
            void AddFunds(decimal amount);
            void RemoveFunds(decimal amount);
        }

        interface ITransferable
        {
            void SendFunds(decimal amount, Account recipient);
        }

        class Account : IDepositable, ITransferable
        {
            public decimal Balance { get; private set; }
            public string Name { get; private set; }

            public Account(string name, decimal initialBalance = 0)
            {
                Name = name;
                Balance = initialBalance;
            }

            public void AddFunds(decimal amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine($"{Name}: сумма пополнения должна быть больше нуля.");
                    return;
                }

                Balance += amount;
                Console.WriteLine($"{Name}: пополнено {amount}. Текущий баланс: {Balance}");
            }

            public void RemoveFunds(decimal amount)
            {
                if (amount <= 0 || amount > Balance)
                {
                    Console.WriteLine($"{Name}: операция снятия невозможна. Проверьте сумму и баланс.");
                    return;
                }

                Balance -= amount;
                Console.WriteLine($"{Name}: снято {amount}. Текущий баланс: {Balance}");
            }

            public void SendFunds(decimal amount, Account recipient)
            {
                if (amount <= 0 || amount > Balance)
                {
                    Console.WriteLine($"{Name}: перевод невозможен. Проверьте сумму и баланс.");
                    return;
                }

                RemoveFunds(amount);
                recipient.AddFunds(amount);
                Console.WriteLine($"Перевод {amount} с {Name} на {recipient.Name} успешно выполнен.");
            }
        }

        class Program
        {
            static void Main()
            {
                Account firstAccount = new Account("Основной счет", 1500);
                Account secondAccount = new Account("Сберегательный счет", 750);

                decimal amountToTransfer = 300;
                Console.WriteLine($"\nПопытка перевода {amountToTransfer} с {firstAccount.Name} на {secondAccount.Name}...\n");

                firstAccount.SendFunds(amountToTransfer, secondAccount);

                Console.WriteLine($"\nБаланс {firstAccount.Name}: {firstAccount.Balance}");
                Console.WriteLine($"Баланс {secondAccount.Name}: {secondAccount.Balance}");
            }
        }
    }
}
