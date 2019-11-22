using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
  public class BankRequester
  {
    public void Response(Request request, Account account)
    {
      IResponse r1 = new XMLResponse();
      IResponse r2 = new CSVResponse(r1);
      IResponse r3 = new PercentResponse(r2);

      r3.Answer(request, account);
    }
  }
}
