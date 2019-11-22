using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
  public class Request
  {
    public Format Format { get; private set; }

    public Request(Format format)
    {
      Format = format;
    }
  }
}
