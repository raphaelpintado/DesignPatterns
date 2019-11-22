using CursoDesignPatterns.Chain_of_Responsibility;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
  public class Orcamento
  {
    public double Valor { get; private set; }
    public IList<Item> Itens { get; private set; }

    public Orcamento(double valor)
    {
      this.Valor = valor;
      this.Itens = new List<Item>();
    }

    public void Add(Item item)
    {
      Itens.Add(item);
    }
  }
}
