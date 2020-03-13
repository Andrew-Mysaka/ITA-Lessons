using System;

namespace Ita.Patterns.Command
{
    public class Withdraw : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsCompleted { get; set; }

        public Withdraw(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("З рахунку {0} списано {1} грн., сума залишку пiсля операцiї {2} грн.",
                    _account.OwnerName, _amount, _account.Balance);
                Console.ResetColor();

                IsCompleted = true;
            }
        }
    }
}