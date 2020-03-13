using System.Collections.Generic;
using System.Linq;

namespace Ita.Patterns.Command
{
    public class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get { return _transactions.Any(x => !x.IsCompleted); }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            foreach (ITransaction transaction in _transactions.Where(x => !x.IsCompleted))
            {
                transaction.Execute();
            }
        }
    }
}