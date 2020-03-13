namespace PatternCommand
{
    public class Account
    {
        public string OwnerName { get; private set; }
        public decimal Balance { get; set; }

        public Account(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}