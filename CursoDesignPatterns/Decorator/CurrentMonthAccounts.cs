using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;

namespace CursoDesignPatterns.Decorator
{
    public class CurrentMonthAccounts : Filter
    {
        public CurrentMonthAccounts()
        {
        }

        public CurrentMonthAccounts(Filter otherFilter) : base(otherFilter)
        {
        }

        public override IList<Account> Search(IList<Account> accounts)
        {
            var filtered = new List<Account>();
            filtered.AddRange(
                accounts
                .Where(x => x.CreatedOn.Month == DateTime.Now.Month &&
                            x.CreatedOn.Year == DateTime.Now.Year).ToList());

            foreach (var item in Next(accounts))
                filtered.Add(item);

            return filtered;
        }
    }
}
