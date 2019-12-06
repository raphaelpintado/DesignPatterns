﻿using CursoDesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Observer
{
    public interface IInvoiceAction
    {
        void Execute(Invoice invoice);
    }
}
