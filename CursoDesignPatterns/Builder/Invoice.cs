using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Builder
{
    public class Invoice
    {        
        public string CorporateName { get; set; }
        public string Cnpj { get; set; }
        public DateTime DateTransmit { get; set; }
        public double TotalValue { get; set; }
        public double Taxes { get; set; }
        public IList<InvoiceItem> Items { get; set; }
        public string Observations { get; set; }

        public Invoice(
            string corporateName, 
            string cnpj, 
            DateTime dateTransmit, 
            double totalValue, 
            double taxes, 
            IList<InvoiceItem> items, 
            string observations)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            DateTransmit = dateTransmit;
            TotalValue = totalValue;
            Taxes = taxes;
            Items = items;
            Observations = observations;
        }
    }
}
