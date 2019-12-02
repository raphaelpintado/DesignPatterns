namespace CursoDesignPatterns.Template_Method
{
    public abstract class ConditionalTaxTemplate : Imposto
    {
        public ConditionalTaxTemplate()
        {
        }

        public ConditionalTaxTemplate(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            double tax; 
            if (ShouldUseMaxTaxation(orcamento))
                tax = MaxTaxation(orcamento);

            else  tax = MinTaxation(orcamento);

            return tax + CalculoDoOutroImposto(orcamento);
        }

        protected abstract double MinTaxation(Orcamento orcamento);
        protected abstract double MaxTaxation(Orcamento orcamento);
        protected abstract bool ShouldUseMaxTaxation(Orcamento orcamento);
    }
}
