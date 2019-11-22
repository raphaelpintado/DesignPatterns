using CursoDesignPatterns.Chain_of_Responsibility;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;
using CursoDesignPatterns.Template_Method;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      //STRATEGY
      /*Orcamento reforma = new Orcamento(500.0);

      IImposto novoImposto = new ICCC();
      Console.WriteLine(novoImposto.Calcula(reforma));      */

      //CHAIN OF RESPONSIBILITY

      /*CalculadorDeDescontos calculador = new CalculadorDeDescontos();

      Orcamento orcamento = new Orcamento(500.0);
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
      Orcamento orcamento = new Orcamento(500.0);
      orcamento.Add(new Item("CANETA", 250.0));
      orcamento.Add(new Item("LAPIS", 250.0));

      ICPP iCPP = new ICPP();
      double tax;
      tax = iCPP.Calcula(orcamento);
      Console.WriteLine($"Valor do ICPP: {tax} ");

      IKCV iKCV = new IKCV();
      tax = iKCV.Calcula(orcamento);
      Console.WriteLine($"Valor do IKCV: {tax} ");

      Console.ReadKey();
    }
  }
}
