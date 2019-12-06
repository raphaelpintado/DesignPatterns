using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Builder;

namespace CursoDesignPatterns.Observer
{
    public class Multiplier : IInvoiceAction
    {
        public double Factor { get; private set; }
        public Multiplier(double factor)
        {
            Factor = factor;
        }

        public void Execute(Invoice invoice)
        {
            Console.WriteLine($"Valor da nota pelo multiplicador: R${invoice.TotalValue*Factor}");
        }
    }
}
