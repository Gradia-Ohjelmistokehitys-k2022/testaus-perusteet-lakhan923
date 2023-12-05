using System.Globalization;
using Bank;

internal class Program
{
    public static void Main(string[] args)
    {
        BankAccount bank = new BankAccount(11.99);
        bank.Credit(5.77);
        bank.Debit(11.22);
        Console.WriteLine("Current balance is $"+ bank.Balance);

        BankCustomer customer = new BankCustomer("Laiba khan");
        BankAccount account = new BankAccount(200);
        customer.AddAccount(100);
        System.Console.WriteLine("initial account count: "+ customer.Accounts.Count);

        customer.RemoveAccount(account);
        Console.WriteLine("Deleted account count: " + customer.Accounts.Count);

        customer.GetTotalBalance();
        System.Console.WriteLine("Total balance: " + customer.GetTotalBalance());



    }
}