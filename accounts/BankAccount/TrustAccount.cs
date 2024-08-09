namespace BankAccount
{
    internal class TrustAccount : SavingsAccount
    {
        private int defaultYear = 2024;
         private int nowyear = DateTime.Now.Year;
         private int triesCount = 3;


        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0)
            : base(name, balance, intRate)
        {
            
        }

        public override bool Deposit(double amount)
        {
            if(amount >= 5000)
            {
                amount += 50;
            }
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {


            if (Balance - amount >= 0 && amount <= (0.2 * Balance) && triesCount >0)
            {
                triesCount--;
                if(nowyear != defaultYear)
                {
                    triesCount = 3;
                    defaultYear = nowyear;
                }
                return base.Withdraw(amount);
            }
            else
            {
                return false;
            }
        }
    }
}