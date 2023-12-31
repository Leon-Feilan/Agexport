﻿// <auto-generated />
using Factura.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Factura.Migrations.Main
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
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
                    b.Property<int>("CodConsumidor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodConsumidor"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<long>("Nit")
                        .HasColumnType("bigint");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("CodConsumidor");

                    b.ToTable("Consumidor");
                });

            modelBuilder.Entity("Factura.Models.Detalle_Factura_ProductoDetail", b =>
                {
                    b.Property<int>("OmitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OmitId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CodFactura_FK")
                        .HasColumnType("int");

                    b.Property<int>("CodProducto_FK")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("OmitId");

                    b.ToTable("detalle_Factura_Producto");
                });

            modelBuilder.Entity("Factura.Models.FacturaDetail", b =>
                {
                    b.Property<int>("CodFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFactura"));

                    b.Property<int>("CodConsumidor_FK")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("CodFactura");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Factura.Models.ProductoDetail", b =>
                {
                    b.Property<int>("CodProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodProducto"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("CodProducto");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
