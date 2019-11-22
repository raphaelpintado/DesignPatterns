using System.Linq;

namespace CursoDesignPatterns.Chain_of_Responsibility
{
  public class DescontoPorVendaCasada : IDesconto
  {
    public IDesconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
      if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
        return orcamento.Valor * 0.05;

      return Proximo.Desconta(orcamento);
    }    

    private bool Existe(string nomeDoItem, Orcamento orcamento)
    {
      return orcamento.Itens.Where(x => x.Nome == nomeDoItem).Any();


      //foreach (Item item in orcamento.Itens)
      //{
      //  if (item.Nome.Equals(nomeDoItem))
      //    return true;
      //}
      //return false;
    }
  }
}
