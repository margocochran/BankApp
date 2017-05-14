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
            var account = new Account();
            ///sets the account name to be My checking
            account.AccountName = "My checking";
            //account.AccountNumber = 123; (users should not set)
            account.EmailAddress = "test@test.com";
            account.TypeOfAccount = "Checking";
            //account.Balance = 100000000;(error because we do not want user to set balance amount)

            account.Deposit(200);
            Console.WriteLine($"AccountNumber: {account.AccountNumber}, Balance: {account.Balance}, EmailAddress: {account.EmailAddress}, TypeOfAccount: {account.TypeOfAccount}");
        } 
    }
}
