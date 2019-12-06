namespace CursoDesignPatterns.Builder
{
    public class InvoiceItem
    {        
        public string Name { get; set; }
        public double Value { get; set; }

        public InvoiceItem(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}