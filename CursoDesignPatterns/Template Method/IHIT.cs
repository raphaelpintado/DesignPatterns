using CursoDesignPatterns.Chain_of_Responsibility;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.Template_Method
{
    public class IHIT : ConditionalTaxTemplate
    {
        public IHIT()
        {
        }

        public IHIT(IImposto outroImposto) : base(outroImposto)
        {
        }

        protected override double MaxTaxation(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinTaxation(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count());
        }

        protected override bool ShouldUseMaxTaxation(Orcamento orcamento)
        {
            return HasRepeatedItems(orcamento.Itens);
        }

        private bool HasRepeatedItems(IList<Item> items)
        {
            return items.GroupBy(a => a.Nome).Any(a => a.Count() > 1);

        }
    }
}
