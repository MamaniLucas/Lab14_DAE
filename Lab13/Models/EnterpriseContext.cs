using Microsoft.EntityFrameworkCore; 


namespace Lab13.Models

{
    public class EnterpriseContext  :DbContext
    {

        public DbSet<Product> Products {  get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Detail> Details { get; set; }  
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server= LAB1504-11\\SQLEXPRESS; Initial catalog=myriamdb;" +
                "User ID = roxana; Password=123456; Integrated Security=True; trustservercertificate=True"
                );
        } 

    }
}
