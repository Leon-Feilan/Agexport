using Microsoft.EntityFrameworkCore;

namespace Factura.Models
{
    public class ProductoDetailContext : DbContext
    {
        public ProductoDetailContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ProductoDetail> ProductoDetail { get; set; }

    }
}
