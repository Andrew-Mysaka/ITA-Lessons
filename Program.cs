using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            TransactionManager transactionManager = new TransactionManager();

            Account mysakaAccount = new Account("Andrew Mysaka", 0);

            Deposit deposit = new Deposit(mysakaAccount, 5000);

            transactionManager.AddTransaction(deposit);

            Account gomonAccount = new Account("Max Gomon", 10000);

            Withdraw withdrawal = new Withdraw(mysakaAccount, 500);
            transactionManager.AddTransaction(withdrawal);

            Transfer transfer = new Transfer(mysakaAccount, gomonAccount, 3000);
            transactionManager.AddTransaction(transfer);

            transactionManager.ProcessPendingTransactions();

            Console.ReadLine();
        }
    }
}
