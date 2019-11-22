using System;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
  public class CSVResponse : IResponse
  {
    public IResponse OtherResponse { get; private set; }

    public CSVResponse(IResponse otherResponse)
    {
      OtherResponse = otherResponse;
    }

    public CSVResponse()
    {
      OtherResponse = null;
    }

    public void Answer(Request request, Account account)
    {
      if (request.Format == Format.CSV)
        Console.WriteLine($"{account.Owner};{account.Balance}");
      else if (OtherResponse != null)
        OtherResponse.Answer(request, account);
      else throw new Exception("Não há formato para o tipo de resposta desejada!");
    }
  }
}
