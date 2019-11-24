using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
    public class Account
    {        
        public string Owner { get; private set; }        
        public string Agency { get; private set; }
        public double NumberAccount { get; private set; }
        public double Balance { get; private set; }

        public Account(string owner, string agency, double numberAccount)
        {
            Owner = owner;
            Agency = agency;
            NumberAccount = numberAccount;
        }

        public void AddBalance(double balance)
        {
            Balance = balance;
        }
    }
}
