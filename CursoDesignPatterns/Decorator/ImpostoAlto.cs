using CursoDesignPatterns.Strategy;

namespace CursoDesignPatterns.Decorator
{
    public class ImpostoAlto : Imposto
    {
        public ImpostoAlto()
        {
        }

        public ImpostoAlto(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
