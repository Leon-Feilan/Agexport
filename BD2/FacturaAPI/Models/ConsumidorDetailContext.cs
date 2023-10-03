using Microsoft.EntityFrameworkCore;

namespace Factura.Models
{
    public class ConsumidorDetailContext:DbContext
    {
        public ConsumidorDetailContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ConsumidorDetail>consumidorDetails { get; set; }
    }
}
