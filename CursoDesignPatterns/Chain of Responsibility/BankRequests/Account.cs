using System;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
    public class Account
    {        
        public string Owner { get; private set; }        
        public string Agency { get; private set; }
        public double NumberAccount { get; private set; }
        public double Balance { get; private set; }
        public DateTime CreatedOn { get; private set; }

        public Account(string owner, string agency, double numberAccount)
        {
            Owner = owner;
            Agency = agency;
            NumberAccount = numberAccount;
            CreatedOn = DateTime.Now;
        }

        public Account(string owner, string agency, double numberAccount, DateTime createdOn) 
            : this(owner, agency, numberAccount)
        {
            CreatedOn = createdOn;
        }

        public void AddBalance(double balance)
        {
            Balance = balance;
        }
    }
}
