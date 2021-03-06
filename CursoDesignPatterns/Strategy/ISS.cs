﻿using CursoDesignPatterns.Decorator;

namespace CursoDesignPatterns.Strategy
{
    public class ISS : Imposto
    {
        public ISS()
        {
        }

        public ISS(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }        
    }
}
