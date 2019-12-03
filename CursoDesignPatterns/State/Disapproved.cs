using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State
{
    public class Disapproved : IBudgetState
    {
        public void ApplyExtraDiscount(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Approves(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento reprovado!");
        }

        public void Disapprove(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um orçamento reprovado!");
        }

        public void Finalized(Orcamento orcamento)
        {
            orcamento.BudgetState = new Finished();
        }
    }
}
