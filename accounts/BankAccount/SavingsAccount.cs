namespace BankAccount
{
    public class SavingsAccount : Account
    {
        public double InterestRata { get; set; }

        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0 , double intRate=0.0) 
            : base(name , balance)
        {
            InterestRata = intRate;
        }
    }
}