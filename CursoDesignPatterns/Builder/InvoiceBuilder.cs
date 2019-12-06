using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Builder
{
    public class InvoiceBuilder
    {
        private string CorporateName { get; set; }
        private string Cnpj { get; set; }
        private string Observations { get; set; }
        private DateTime Date { get; set; }
        private double TotalValue;
        private double Taxes;
        private IList<InvoiceItem> AllItems = new List<InvoiceItem>();

        public InvoiceBuilder()
        {
            Date = DateTime.Now;
        }

        public InvoiceBuilder ToCompany(string corporateName)
        {
            CorporateName = corporateName;
            return this;
        }
        
        public InvoiceBuilder AddCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public InvoiceBuilder Add(InvoiceItem item)
        {
            AllItems.Add(item);
            TotalValue += item.Value;
            Taxes += item.Value * 0.05;
            return this;
        }

        public InvoiceBuilder SetDateTransmit(DateTime date)
        {
            Date = date;
            return this;
        }

        public InvoiceBuilder AddObservation(string observation)
        {
            Observations = observation;
            return this;
        }

        public Invoice Build()
        {            
            return new Invoice(CorporateName, Cnpj, Date, TotalValue, Taxes, AllItems, Observations);
        }
    }
}
