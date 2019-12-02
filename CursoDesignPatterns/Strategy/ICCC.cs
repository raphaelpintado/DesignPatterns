using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
  public class ICCC : Imposto
  {
        public ICCC()
        {
        }

        public ICCC(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
    {
      if (orcamento.Valor < 1000)
        return orcamento.Valor * 0.05;
      else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
        return orcamento.Valor * 0.07;
      else 
        return orcamento.Valor * 0.08 + 30;
    }
  }
}
