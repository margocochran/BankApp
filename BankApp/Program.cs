using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome to My Bank**************");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print all accounts");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return; //this is a method in C# to exit a program
                    case "1":
                        Console.Write("Account Name: "); //Console.Write - cursor will not go to next line
                        var accountName = Console.ReadLine();
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        Console.WriteLine("Type of Account:");
                        var accountTypes = Enum.GetNames(typeof(AccountTypes)); //accountTypes now contains the four values that make up Account Types
                        for (int i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {accountTypes[i]}");
                        }
                        Console.Write("Pick an account type: ");
                        var accountType = Convert.ToInt32(Console.ReadLine()); //accountType is singular here to differentiate from prev.
                        Console.Write("Amount: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        var account = Bank.CreateAccount(emailAddress, (AccountTypes)accountType, amount, accountName);
                        Console.WriteLine($"AccountNumber: {account.AccountNumber}, Balance: {account.Balance:C}, EmailAddress: {account.EmailAddress}, TypeOfAccount: {account.TypeOfAccount}");
                        break; //this is needed at the end of each case
                    case "2":
                    case "3":
                    case "4":
                    default:
                        break;
                }
            }

            //Everything below can be deleted!!!
            //var account = new Account("My checking", "test@test.com",  AccountTypes.Checking, 200);
            //sets the account name to be My checking
            // account.AccountName = "My checking";
            //account.AccountNumber = 123; (users should not set)
            //account.EmailAddress = "test@test.com";
            //account.TypeOfAccount = "Checking";
            //account.Balance = 100000000;(error because we do not want user to set balance amount)

            //account.Deposit(200);
            //Console.WriteLine($"AccountNumber: {account.AccountNumber}, Balance: {account.Balance:C}, EmailAddress: {account.EmailAddress}, TypeOfAccount: {account.TypeOfAccount}");

            //var account2 = new Account
            // {
            //   EmailAddress = "test@test.com",
            //   TypeOfAccount =  AccountTypes.Savings
            // };
            // Console.WriteLine($"AccountNumber: {account2.AccountNumber}, Balance: {account2.Balance:C}, EmailAddress: {account2.EmailAddress}, TypeOfAccount: {account2.TypeOfAccount}");

        } 
    }
}
