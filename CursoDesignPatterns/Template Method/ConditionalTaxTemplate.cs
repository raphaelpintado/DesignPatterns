namespace CursoDesignPatterns.Template_Method
{
  public abstract class ConditionalTaxTemplate : IImposto
  {
    public double Calcula(Orcamento orcamento)
    {
      if (ShouldUseMaxTaxation(orcamento))
        return MaxTaxation(orcamento);

      return MinTaxation(orcamento);
    }

    protected abstract double MinTaxation(Orcamento orcamento);
    protected abstract double MaxTaxation(Orcamento orcamento);
    protected abstract bool ShouldUseMaxTaxation(Orcamento orcamento);
  }
}
