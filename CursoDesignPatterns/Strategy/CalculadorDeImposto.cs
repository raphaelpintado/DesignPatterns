namespace CursoDesignPatterns
{
  public class CalculadorDeImposto
  {
    public void Calcula(Orcamento orcamento, IImposto imposto)
    {
      double resulta = imposto.Calcula(orcamento);
    }
  }
}
