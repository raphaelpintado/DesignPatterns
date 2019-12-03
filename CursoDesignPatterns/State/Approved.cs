using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State
{
    public class Approved : IBudgetState
    {
        private bool DiscountApplied = false;

        public void ApplyExtraDiscount(Orcamento orcamento)
        {
            if (!DiscountApplied)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                DiscountApplied = true;
            }
            else
                throw new Exception("Desconto extra para orçamento 'Aprovado' já aplicado!");
        }

        public void Approves(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado!");
        }

        public void Disapprove(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado!");
        }

        public void Finalized(Orcamento orcamento)
        {
            orcamento.BudgetState = new Finished();
        }
    }
}
