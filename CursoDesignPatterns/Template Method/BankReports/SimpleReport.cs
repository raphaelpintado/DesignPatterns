using System;
using System.Collections.Generic;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;

namespace CursoDesignPatterns.Template_Method.BankReports
{
    public class SimpleReport : BaseReportTemplate
    {
        protected override void PrintBody(IList<Account> accounts)
        {
            Console.WriteLine();
            (accounts as List<Account>).ForEach(account => Console.WriteLine($"Titular: {account.Owner}{Environment.NewLine}" +
                                                                             $"Saldo: R${account.Balance}{Environment.NewLine}"));
            Console.WriteLine();
        }

        protected override void PrintFooter(Bank bank)
        {
            PrintHeader(bank);
        }

        protected override void PrintHeader(Bank bank)
        {
            Console.WriteLine($"Banco: {bank.CorporateName}   Telefone: {bank.Phone}");
        }
    }
}
