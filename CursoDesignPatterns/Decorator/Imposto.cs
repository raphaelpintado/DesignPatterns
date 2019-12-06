using CursoDesignPatterns.Strategy;

namespace CursoDesignPatterns.Decorator
{
    public abstract class Imposto : IImposto
    {
        public IImposto OutroImposto { get; set; }

        public Imposto()
        {
            OutroImposto = null;
        }

        public Imposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
                return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}
