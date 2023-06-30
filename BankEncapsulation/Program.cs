namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Please enter the amount you wish to deposit.");
            double dInput = double.Parse(Console.ReadLine());
            myAccount.Deposit(dInput);
            Console.WriteLine($"You deposited ${dInput}.");
            double currentBalance = myAccount.GetBalance();
            Console.WriteLine($"Current balance in account is: ${currentBalance}.");

            Console.WriteLine();

            Console.WriteLine("Please enter the amount you wish to withdraw.");
            double wInput = double.Parse(Console.ReadLine());
            myAccount.Withdraw(wInput);
            Console.WriteLine($"You withdrew ${wInput}.");
            double newCurrentBalance = myAccount.GetBalance();
            Console.WriteLine($"Current balance in account is: ${newCurrentBalance}.");

        }
    }
}
