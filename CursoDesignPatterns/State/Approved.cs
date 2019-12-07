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

        public double ApplyExtraDiscount(Orcamento orcamento)
        {
            if (!DiscountApplied)
            {                
                DiscountApplied = true;

                var discount = orcamento.Valor * 0.02;
                orcamento.Valor -= discount;

                return discount;
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
