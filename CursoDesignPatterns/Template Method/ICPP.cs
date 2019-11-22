namespace CursoDesignPatterns.Template_Method
{
  public class ICPP : ConditionalTaxTemplate
  {
    protected override double MaxTaxation(Orcamento orcamento)
    {
      return orcamento.Valor * 0.07;
    }

    protected override double MinTaxation(Orcamento orcamento)
    {
      return orcamento.Valor * 0.05;
    }

    protected override bool ShouldUseMaxTaxation(Orcamento orcamento)
    {
      return orcamento.Valor >= 500;
    }
  }
}
