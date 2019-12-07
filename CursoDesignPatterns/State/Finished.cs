using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.State
{
    public class Finished : IBudgetState
    {
        public double ApplyExtraDiscount(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Approves(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento finalizado!");
        }

        public void Disapprove(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um orçamento finalizado!");
        }

        public void Finalized(Orcamento orcamento)
        {
            throw new Exception("Não é possível finalizar um orçamento finalizado!");
        }
    }
}
