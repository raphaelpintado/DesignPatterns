using System.Collections.Generic;
using System.Linq;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;

namespace CursoDesignPatterns.Decorator
{
    public class LowBallanceAccounts : Filter
    {
        public LowBallanceAccounts() : base()
        {
        }

        public LowBallanceAccounts(Filter otherFilter) : base(otherFilter)
        {
        }

        public override IList<Account> Search(IList<Account> accounts)
        {
            var filtered = new List<Account>();
            filtered.AddRange(accounts.Where(x => x.Balance < 100).ToList());

            foreach (Account item in Next(accounts))
            {
                filtered.Add(item);
            }

            return filtered;
        }
    }
}
