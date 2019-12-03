using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State
{
    public class OnApproval : IBudgetState
    {
        private bool DiscountApplied = false;

        public void ApplyExtraDiscount(Orcamento orcamento)
        {
            if (!DiscountApplied)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                DiscountApplied = true;
            }
            else
                throw new Exception("Desconto extra para orçamento 'Em Aprovação' já aplicado!");
        }


        public void Approves(Orcamento orcamento)
        {
            orcamento.BudgetState = new Approved();
        }

        public void Disapprove(Orcamento orcamento)
        {
            orcamento.BudgetState = new Disapproved();
        }

        public void Finalized(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ir diretamente para o estado Finalizado!");
        }
    }
}
