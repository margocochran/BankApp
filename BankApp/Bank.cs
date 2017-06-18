using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>(); 

        public static string Name { get; set; }

        public static Account CreateAccount(string emailAddress, AccountTypes typeOfAccount, decimal amount, string accountName)
        {
            var account = new Account ///lower case account is the instance - use from this point on
            {
                AccountName = accountName,
                TypeOfAccount = typeOfAccount,
                EmailAddress = emailAddress
            };

            if (amount > 0)
            {
                account.Deposit(amount); 
            }
            accounts.Add(account);
            return account; 
        }

        public static List<Account> GetAllAccounts()
        {
            return accounts; 
        }

        public static Account GetAccountByAccountNumber(int accountNumber)
        {
            return accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault(); 
        }

        public static void Deposit(Account account, decimal amount)
        {
            account.Deposit(amount); 
        }

        public static void Withdraw(Account account, decimal amount)
        {
            account.Withdraw(amount);
        }
    }
}
