using CursoDesignPatterns.Builder;
using CursoDesignPatterns.Chain_of_Responsibility;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;
using CursoDesignPatterns.Decorator;
using CursoDesignPatterns.Observer;
using CursoDesignPatterns.Strategy;
using CursoDesignPatterns.Template_Method;
using CursoDesignPatterns.Template_Method.BankReports;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            Orcamento orcamento = new Orcamento();
            orcamento.Add(new Item("CANETA", 250.0));
            orcamento.Add(new Item("LAPIS", 250.0));

            IImposto novoImposto = new ICCC();
            Console.WriteLine(novoImposto.Calcula(orcamento));

            Console.ReadKey();

            #endregion

            #region Chain of Responsibility

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();

            List<Request> requests = new List<Request>();

            var xmlRequest = new Request(Format.XML);
            var csvRequest = new Request(Format.CSV);
            var percentRequest = new Request(Format.PERCENT);

            requests.Add(xmlRequest);
            requests.Add(csvRequest);
            requests.Add(percentRequest);

            var account = new Account("Raphael", "3252-2", 17508, 6000.99);
            var bankRequest = new BankRequester();

            requests.ForEach(x => bankRequest.Response(x, account));
            Console.ReadKey();

            #endregion

            #region Template Method

            orcamento = new Orcamento();
            orcamento.Add(new Item("CANETA", 250.0));
            orcamento.Add(new Item("LAPIS", 250.0));
            orcamento.Add(new Item("APAGADOR", 50.0));
            orcamento.Add(new Item("BORRACHA", 10.0));
            orcamento.Add(new Item("BORRACHA", 10.0));
            orcamento.Add(new Item("BORRACHA", 10.0));

            ICPP iCPP = new ICPP();
            double tax;
            tax = iCPP.Calcula(orcamento);
            Console.WriteLine($"Valor do ICPP: {tax} ");

            IKCV iKCV = new IKCV();
            tax = iKCV.Calcula(orcamento);
            Console.WriteLine($"Valor do IKCV: {tax} ");

            var iHIT = new IHIT();
            tax = iHIT.Calcula(orcamento);
            Console.WriteLine($"Valor do IHIT: {tax} ");

            Console.ReadKey();

            Bank bank = new Bank()
            {
                CorporateName = "Banco do Brasil S/A",
                Phone = "6666-12345",
                Address = "Av. Borges de Medeiros, Nº123",
                Email = "banco_do_brasil@BB.com.br",
                Date = DateTime.Now
            };

            account = new Account("Pintado", "3252-2", 17508, 6000.99);

            IList<Account> accounts = new List<Account>();
            accounts.Add(account);

            account = new Account("Raphael", "1404-5", 52223, 8500);
            accounts.Add(account);

            Console.WriteLine("Imprimindo relatório simplificado... ");
            IReport report = new SimpleReport();
            report.Print(accounts, bank);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Imprimindo relatório completo... ");
            report = new ComplexReport();
            report.Print(accounts, bank);

            Console.ReadKey();

            #endregion

            #region Decorator e Comportamentos Compostos

            var iss = new ISS(new ICMS(new IKCV()));
            var imposto = new ImpostoAlto(new ICPP(new IHIT(new IKCV())));

            orcamento = new Orcamento();
            orcamento.Add(new Item("CANETA", 250.0));
            orcamento.Add(new Item("LAPIS", 250.0));

            double valor = imposto.Calcula(orcamento);
            Console.WriteLine($"Imposto Alto: R${valor}");
            valor = iss.Calcula(orcamento);
            Console.WriteLine($"Valor do ISS: R${valor}");
            Console.ReadKey();

            account = new Account("Pintado", "3252-2", 17508, new DateTime(2015, 05, 07));
            account.Deposit(50);

            accounts = new List<Account>();
            accounts.Add(account);

            account = new Account("Raphael", "1404-5", 52223, new DateTime(2015, 05, 07));
            account.Deposit(850000);

            accounts.Add(account);

            account = new Account("Teste", "3252-2", 666, 6500);

            accounts.Add(account);

            var filter = new CurrentMonthAccounts(new LowBallanceAccounts());

            var filteredAccounts = filter.Search(accounts);

            bank = new Bank()
            {
                CorporateName = "Banco do Brasil S/A",
                Phone = "6666-12345",
                Address = "Av. Borges de Medeiros, Nº123",
                Email = "banco_do_brasil@BB.com.br",
                Date = DateTime.Now
            };

            report = new ComplexReport();
            report.Print(filteredAccounts, bank);
            Console.ReadKey();

            #endregion

            //STATE PATTERN 
            /*var orcamento = new Orcamento();
            orcamento.Add(new Item("Estados do Orçamento", 500));

            Console.WriteLine(orcamento.Valor);

            orcamento.ApplyExtraDiscount();
            Console.WriteLine(orcamento.Valor);

            orcamento.ApplyExtraDiscount();

            orcamento.Approves();

            orcamento.ApplyExtraDiscount();
            Console.WriteLine(orcamento.Valor);

            orcamento.Finalized();            

            Console.ReadKey(); */

            /*var account = new Account("Pintado", "3252-2", 17508, 5000);
            account.CashWithDrawal(6000);
            Console.WriteLine("Saque Realizado!");
            Console.WriteLine($"Nome:{account.Owner}, Saldo R${account.Balance}");

            account.CashWithDrawal(2000);
            account.Deposit(2000);
            Console.WriteLine("Depósito Realizado!");
            Console.WriteLine($"Nome:{account.Owner}, Saldo R${account.Balance}");

            account.Deposit(2000);
            Console.WriteLine("Depósito Realizado!");
            Console.WriteLine($"Nome:{account.Owner}, Saldo R${account.Balance}");

            Console.ReadKey(); */

            #region Builder

            var builder = new InvoiceBuilder();
            builder.ToCompany("Alura Design Patterns LTDA.")
            .AddCnpj("45.429.459/0001-43")
            .Add(new InvoiceItem("Item 1", 100.0))
            .Add(new InvoiceItem("Item 2", 200.0))
            .AddObservation("Add some observation");

            #region Observer Pattern
            builder.AddAction(new EmailSender())
                   .AddAction(new InvoiceDAO())
                   .AddAction(new SmsSender())
                   .AddAction(new Multiplier(5));

            #endregion

            var nf = builder.Build();

            Console.WriteLine($"Valor da Nota: R${nf.TotalValue}");
            Console.WriteLine($"Taxas: R${nf.Taxes}");

            Console.ReadKey();

            #endregion
        }
    }
}
