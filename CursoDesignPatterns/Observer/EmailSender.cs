﻿using CursoDesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Observer
{
    public class EmailSender : IInvoiceAction
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Nota fiscal enviada por e-mail");
        }
    }
}
