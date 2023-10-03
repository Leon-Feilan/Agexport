using Microsoft.EntityFrameworkCore;

namespace Factura.Models
{
    public class MainContext:DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {

        }

        //getting tables

        //Factura
        public DbSet<FacturaDetail> Factura { get; set; }

        //Consumidor
        public DbSet<ConsumidorDetail> Consumidor { get; set;}

        //Producto
        public DbSet<ProductoDetail>Producto { get; set; }

        //Detalle Producto Factura
        public DbSet<Detalle_Factura_ProductoDetail> detalle_Factura_Producto {  get; set; }

        
    }
}
