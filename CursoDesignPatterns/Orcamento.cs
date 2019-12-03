using CursoDesignPatterns.Chain_of_Responsibility;
using CursoDesignPatterns.State;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public IBudgetState BudgetState { get; set; }

        public Orcamento()
        {
            Itens = new List<Item>();
            BudgetState = new OnApproval();
        }

        public void Add(Item item)
        {
            Itens.Add(item);
            RefreshBudget(item.Valor);
        }

        private void RefreshBudget(double valor)
        {
            Valor += valor;
        }

        public void ApplyExtraDiscount()
        {
            BudgetState.ApplyExtraDiscount(this);
        }

        public void Approves() => BudgetState.Approves(this);

        public void Disapprove() => BudgetState.Disapprove(this);

        public void Finalized() => BudgetState.Finalized(this);
    }
}
