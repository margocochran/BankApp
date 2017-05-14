using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
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

        public string TypeOfAccount { get; set; }
        #endregion

        #region Constructor
        public Account()
        {
            lastAccountNumber ++ 1;
            AccountNumber = lastAccountNumber; 
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
