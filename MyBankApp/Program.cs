using System;

namespace MyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<name>", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
