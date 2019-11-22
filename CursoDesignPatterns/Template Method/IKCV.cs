namespace CursoDesignPatterns.Template_Method
{
  public class IKCV : ConditionalTaxTemplate
  {
    protected override bool ShouldUseMaxTaxation(Orcamento orcamento)
    {
      return orcamento.Valor > 500 && HasItemMoreThan100Reais(orcamento);
    }

    protected override double MaxTaxation(Orcamento orcamento)
    {
      return orcamento.Valor * 0.10; 
    }

    protected override double MinTaxation(Orcamento orcamento)
    {
      return orcamento.Valor * 0.06;
    }   

    private bool HasItemMoreThan100Reais(Orcamento orcamento)
    {
      foreach (var item in orcamento.Itens)
      {
        if (item.Valor > 100)
          return true;
      }

      return false;
    }
  }
}
