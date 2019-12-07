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

        public double ApplyExtraDiscount(Orcamento orcamento)
        {
            if (!DiscountApplied)
            {                
                DiscountApplied = true;

                var discount = orcamento.Valor * 0.05;
                orcamento.Valor = orcamento.Valor - discount;

                return discount;
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
