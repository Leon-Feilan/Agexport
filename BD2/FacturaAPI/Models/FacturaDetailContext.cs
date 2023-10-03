using Microsoft.EntityFrameworkCore;

namespace Factura.Models
{
    public class FacturaDetailContext : DbContext
    {
        public FacturaDetailContext(DbContextOptions options) : base(options)
        {

        }

        //Making sure to get the Table
        public DbSet<FacturaDetail>FacturaDetail { get; set; }

    }
}
