namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS()
        {
        }

        public ICMS(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
