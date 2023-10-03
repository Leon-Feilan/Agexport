﻿// <auto-generated />
using Factura.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Factura.Migrations.ConsumidorDetail
{
    [DbContext(typeof(ConsumidorDetailContext))]
    partial class ConsumidorDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Factura.Models.ConsumidorDetail", b =>
                {
                    b.Property<int>("Nit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nit"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Nit");

                    b.ToTable("consumidorDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
