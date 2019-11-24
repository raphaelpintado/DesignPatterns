﻿using CursoDesignPatterns.Chain_of_Responsibility;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;
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
            //STRATEGY
            /*Orcamento reforma = new Orcamento();

            IImposto novoImposto = new ICCC();
            Console.WriteLine(novoImposto.Calcula(reforma));      */

            //CHAIN OF RESPONSIBILITY

            /*CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento();
            orcamento.Add(new Item("CANETA", 250.0));
            orcamento.Add(new Item("LAPIS", 250.0));

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

            var account = new Account("Raphael", 6000.99);
            var bankRequest = new BankRequester();

            requests.ForEach(x => bankRequest.Response(x, account));
            Console.ReadKey(); */

            //TEMPLATE METHOD

            /*Orcamento orcamento = new Orcamento();
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

            Console.ReadKey(); */

            Bank bank = new Bank()
            {
                CorporateName = "Banco do Brasil S/A",
                Phone = "6666-12345",
                Address = "Av. Borges de Medeiros, Nº123",
                Email = "banco_do_brasil@BB.com.br",
                Date = DateTime.Now
            };

            Account account = new Account("Pintado", "3252-2", 17508.0);
            account.AddBalance(6000.99);

            IList<Account> accounts = new List<Account>();
            accounts.Add(account);

            account = new Account("Raphael", "1404-5", 52223.6);
            account.AddBalance(8500);

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
        }
    }
}
