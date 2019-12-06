using CursoDesignPatterns.State;
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
        public IAccountState AccountState { get; private set; }

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

        public Account(string owner, string agency, double numberAccount, double balance)
            : this(owner, agency, numberAccount)
        {
            Balance = balance;
            CreatedOn = DateTime.Now;
            if (Balance > 0)
                AccountState = new PositiveBalance();
            else AccountState = new NegativeBalance();
        }        

        public void CashWithDrawal(double value) => AccountState.CashWithdrawal(this, value);

        public void Deposit(double value) => AccountState.Deposit(this, value);

        internal class PositiveBalance : IAccountState
        {
            public void CashWithdrawal(Account account, double value)
            {
                account.Balance -= value;
                if (account.Balance < 0)
                    account.AccountState = new NegativeBalance();
            }

            public void Deposit(Account account, double value)
            {
                account.Balance += value * 0.98;
            }
        }

        internal class NegativeBalance : IAccountState
        {
            public void CashWithdrawal(Account account, double value)
            {
                Console.WriteLine($"Não há saldo em conta para realizar o saque! Saldo: R${account.Balance}");
            }

            public void Deposit(Account account, double value)
            {
                account.Balance += value * 0.95;
                if (account.Balance > 0)
                    account.AccountState = new PositiveBalance();
            }
        }
    }
}
