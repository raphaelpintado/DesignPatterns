using System;
using System.Collections.Generic;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;

namespace CursoDesignPatterns.Template_Method.BankReports
{
    public class ComplexReport : BaseReportTemplate
    {
        protected override void PrintBody(IList<Account> accounts)
        {
            Console.WriteLine();

            (accounts as List<Account>).
                ForEach(account => Console.WriteLine(
                    $"Titular: {account.Owner}{Environment.NewLine}" +
                    $"Agência: {account.Agency}{Environment.NewLine}" +
                    $"Número da Conta: {account.NumberAccount}{Environment.NewLine}" +
                    $"Saldo: R${account.Balance}{Environment.NewLine} " +
                    $"Data de Criação: {account.CreatedOn}{Environment.NewLine}"));

            Console.WriteLine();
        }

        protected override void PrintFooter(Bank bank)
        {
            Console.WriteLine($"Email: {bank.Email}{Environment.NewLine}Data: {bank.Date}");
        }

        protected override void PrintHeader(Bank bank)
        {
            Console.WriteLine($"Banco: {bank.CorporateName}{Environment.NewLine}" +
                              $"Endereço: {bank.Address}{Environment.NewLine}" +
                              $"Telefone: {bank.Phone}");
        }
    }
}
