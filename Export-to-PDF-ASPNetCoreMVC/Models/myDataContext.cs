using Microsoft.EntityFrameworkCore;

namespace Export_to_PDF_ASPNetCoreMVC.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext(DbContextOptions<myDataContext> options) : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
    }
}