using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
  public class Account
  {
    public string Owner { get; private set; }
    public double Balance { get; private set; }

    public Account(string owner, double balance)
    {
      Owner = owner;
      Balance = balance;
    }
  }
}
