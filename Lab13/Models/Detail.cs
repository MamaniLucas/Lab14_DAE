namespace Lab13.Models
{
    public class Detail
    {

        public int DetailId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }



        public Invoice Invoice { get; set; }
        public int invoiceId { get; set; }



        public int Amount { get; set; }
        public float Price { get; set; }    
        public float Subtotal { get; set; }

    }
}
