namespace BankAccount
{
    public class CheckingAccount : Account
    {
        private double feeAmount = 0;
        private double fee = 1.5;
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0)
            :base(name , balance )      
        {
            
        }
        public override bool Withdraw(double amount )
        {
            if ( Balance >= (amount - fee))
            {
                feeAmount += fee;
                return base.Withdraw(amount+fee);
            }
            else
            {
                return false;
            }
        }
    }
}