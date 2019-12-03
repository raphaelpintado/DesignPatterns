using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State
{
    public interface IAccountState
    {
        void CashWithdrawal(Account account, double value);
        void Deposit(Account account, double value);
    }
}
