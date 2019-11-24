using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Template_Method
{
    public interface IReport
    {
        void Print(IList<Account> accounts, Bank bank);
    }
}
