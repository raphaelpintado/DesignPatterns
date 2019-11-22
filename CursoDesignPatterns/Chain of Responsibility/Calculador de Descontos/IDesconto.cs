namespace CursoDesignPatterns.Chain_of_Responsibility
{
  public interface IDesconto
  {    
    double Desconta(Orcamento orcamento);
    IDesconto Proximo { get; set; }
  }
}
