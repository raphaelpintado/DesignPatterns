using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State
{
    public interface IBudgetState
    {
        void ApplyExtraDiscount(Orcamento orcamento);

        void Approves(Orcamento orcamento);
        void Disapprove(Orcamento orcamento);
        void Finalized(Orcamento orcamento);
    }
}
