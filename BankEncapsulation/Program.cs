namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Please enter the amount you wish to deposit.");
            myAccount.Deposit(100);
            Console.WriteLine("You deposited $100.");
            double currentBalance = myAccount.GetBalance();
            Console.WriteLine($"Current balance in account is: ${currentBalance}.");

            Console.WriteLine();

            Console.WriteLine("Please enter the amount you wish to withdraw.");
            myAccount.Withdraw(25);
            Console.WriteLine("You withdrew $25.");
            double newCurrentBalance = myAccount.GetBalance();
            Console.WriteLine($"Current balance in account is: ${newCurrentBalance}.");

        }
    }
}
