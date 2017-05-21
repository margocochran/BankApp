using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public enum AccountTypes
    {
        Checking, 
        Savings, 
        CreditCard,
        Loan
    }
    /// <summary>
    /// Bank Account thath holds all of the information 
    /// of an account.
    /// </summary>
    class Account
    {
        private static int lastAccountNumber = 0;
        #region Properties
        /// <summary>
        /// Account number for the account
        /// </summary>
        public int AccountNumber { get; private set; }

        public string AccountName { get; set; }

        public string EmailAddress { get; set; }

        public decimal Balance { get; private set; }

        public AccountTypes TypeOfAccount { get; set; }
        #endregion

        #region Constructor
        public Account()
        {
            lastAccountNumber ++;
            AccountNumber = lastAccountNumber; 
        }
    
        public Account(string accountName) : this()
        {
            AccountName = accountName; 
        }

        public Account(string accountName, string emailAddress) : this(accountName)
        {
            EmailAddress = emailAddress;
        }

        public Account(string accountName, string emailAddress, AccountTypes typeOfAccount) : this(accountName, emailAddress)
        {
            TypeOfAccount = typeOfAccount;
        }

        public Account(string accountName, string emailAddress, AccountTypes typeOfAccount, decimal amount) : this(accountName, emailAddress, typeOfAccount)
        {
            Deposit(amount); 
        }


        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount; 
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount; 
        }
        #endregion
    }
}
