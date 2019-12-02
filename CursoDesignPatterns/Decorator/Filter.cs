using CursoDesignPatterns.Chain_of_Responsibility.BankRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Decorator
{
    public abstract class Filter
    {
        public Filter OtherFilter { get; private set; }

        public Filter()
        {
            OtherFilter = null;
        }

        public Filter(Filter otherFilter)
        {
            OtherFilter = otherFilter;
        }

        public abstract IList<Account> Search(IList<Account> accounts);

        protected IList<Account> Next(IList<Account> accounts)
        {
            if (OtherFilter == null)
                return new List<Account>();

            return OtherFilter.Search(accounts);
        }
    }
}
