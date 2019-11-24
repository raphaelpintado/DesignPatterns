using System;
using System.Collections.Generic;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;

namespace CursoDesignPatterns.Template_Method
{
    public abstract class BaseReportTemplate : IReport
    {
        public void Print(IList<Account> accounts, Bank bank)
        {
            Console.WriteLine("##################### CABEÇALHO #####################");
            PrintHeader(bank);
            Console.WriteLine("#####################################################");

            PrintBody(accounts);

            Console.WriteLine("##################### RODAPÉ ########################");
            PrintFooter(bank);
            Console.WriteLine("#####################################################");

        }
        protected abstract void PrintHeader(Bank bank);
        protected abstract void PrintBody(IList<Account> accounts);
        protected abstract void PrintFooter(Bank bank);
    }
}
