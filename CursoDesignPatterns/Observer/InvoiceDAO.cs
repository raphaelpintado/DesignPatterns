using CursoDesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Observer
{
    public class InvoiceDAO : IInvoiceAction
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Nota fiscal enviada para o Banco de Dados!");
        }
    }
}
