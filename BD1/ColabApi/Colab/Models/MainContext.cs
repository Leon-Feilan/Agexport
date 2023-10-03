using Microsoft.EntityFrameworkCore;

namespace Colaborador.Models

{
    public class MainContext:DbContext
    {

        public MainContext(DbContextOptions options) : base(options) { 
        
        }

        //creating tables

        public DbSet<ColaboradorDetail> Colaborador { get; set;}
        public DbSet<GeneroDetail> Genero { get; set;}
        public DbSet<TipoColaborador> TipoColaborador { get;set;}
        public DbSet<SectorEmpresarialDetail> SectorEmpresarial { get; set;}
        public DbSet<Detalle_Colaborador_SectorDetail> Detalle_Colaborador_Sector {  get; set;}





    }
}
