using ExtentionMethods;
using System.Xml.Linq;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccountModel account = ConsoleHelper.GetCustomerInfo();
            ConsoleHelper.PrintCustomerInfo(account);

            //AskTransaction()
            Console.WriteLine("Which account would you like to ");
            Console.WriteLine("what would you like to do (withdraw/deposit): ");
            Console.WriteLine("Which account would you like to ");
            string userAnswer = "";
            if (userAnswer == "deposit")
            {
                double amount = ConsoleHelper.ValidateDouble("How much would you like to deposit: ");
                account.
            }

            Console.ReadLine();
        }
    }
    public class BankAccountModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double CheckingAccount { get; set; }
        public double SavingsAccount { get; set; }
    }


}
public static class ConsoleHelper
{
    public static void DepositCheckings(this int amount, BankAccountModel account)
    {
        double newAmount = account.CheckingAccount += amount;
        Console.WriteLine($"You now have {newAmount} in your Checking Account");
    }
    public static void DepositSavings(this int amount, BankAccountModel savingsAccount)
    {
        double newAmount = savingsAccount.SavingsAccount += amount;
        Console.WriteLine($"You now have {newAmount} in your Checking Account");
    }
    public static BankAccountModel GetCustomerInfo()
    {
        BankAccountModel account = new BankAccountModel();
        Console.WriteLine("Hello, to create a new bank account please enter the following...");
        GetFirstName(account, "First name: ");
        GetLastName(account, "Last name: ");
        GetInitialCheckingsDeposit(account, "Initial Checking deposit: ");
        GetInitialSavingsDeposit(account, "initial Savings deposit: ");
        return account;

    }

    public static void PrintCustomerInfo(BankAccountModel account)
    {
        Console.WriteLine($"{account.FirstName} {account.LastName} has ${account.CheckingAccount} in checking accounts \n" +
            $"and ${account.SavingsAccount} in thier savings account");
    }


    private static void GetFirstName(BankAccountModel account, string question)
    {
        Console.Write(question);
        account.FirstName = Console.ReadLine();
    }
    private static void GetLastName(BankAccountModel account, string question)
    {
        Console.Write(question);
        account.LastName = Console.ReadLine();
    }
    private static void GetInitialCheckingsDeposit(BankAccountModel account, string question)
    {
        double amount = ValidateDouble(question);
        account.CheckingAccount += amount;
    }

    public static double ValidateDouble(string question)
    {
        bool isValidDouble = false;
        double amount = 0;
        while (isValidDouble == false)
        {
            Console.Write(question);
            isValidDouble = double.TryParse(Console.ReadLine(), out amount);

        }

        return amount;
    }

    private static void GetInitialSavingsDeposit(BankAccountModel account, string question)
    {
        bool isValidDouble = false;
        double amount = 0;
        while (isValidDouble == false)
        {
            Console.Write(question);
            isValidDouble = double.TryParse(Console.ReadLine(), out amount);

        }
        account.SavingsAccount += amount;
    }


}