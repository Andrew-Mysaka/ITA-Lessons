using System;

namespace Ita.Patterns.Command
{
    public class Deposit : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsCompleted { get; set; }

        public Deposit(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            _account.Balance += _amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("На рахунок {0} зараховано {1} грн., сума залишку пiсля операцiї становить {2} грн.",
                _account.OwnerName, _amount, _account.Balance);
            Console.ResetColor();

            IsCompleted = true;
        }
    }
}