using System;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
  public class XMLResponse : IResponse
  {
    public IResponse OtherResponse { get; private set; }

    public XMLResponse(IResponse otherResponse)
    {
      OtherResponse = otherResponse;
    }

    public XMLResponse()
    {
      OtherResponse = null;
    }

    public void Answer(Request request, Account account)
    {
      if (request.Format == Format.XML)
        Console.WriteLine($"<conta><titular>{account.Owner}</titular><saldo>{account.Balance}</saldo></conta>");
      else if (OtherResponse != null)
        OtherResponse.Answer(request, account);      
      else throw new Exception("Não há formato para o tipo de resposta desejada!");
    }
  }
}
