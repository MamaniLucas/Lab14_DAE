namespace Lab13.Models
{
    public class Invoice
    {

        public int InvoiceId { get; set; }
        public Customer customer { get; set; }
        public int CustomerId { get; set; }
    }
}
