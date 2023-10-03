using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class Colab1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    CodColaborador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dpi = table.Column<long>(type: "bigint", nullable: false),
                    Nombre_1 = table.Column<string>(type: "varchar(30)", nullable: false),
                    Nombre_2 = table.Column<string>(type: "varchar(30)", nullable: false),
                    Apellido_1 = table.Column<string>(type: "varchar(30)", nullable: false),
                    Apellido_2 = table.Column<string>(type: "varchar(30)", nullable: false),
                    CodGenero_FK = table.Column<int>(type: "int", nullable: false),
                    FechaDeNacimiento = table.Column<string>(type: "varchar(12)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.CodColaborador);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Colaborador_Sector",
                columns: table => new
                {
                    OmitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodColaborador_FK = table.Column<int>(type: "int", nullable: false),
                    CodSector_FK = table.Column<int>(type: "int", nullable: false),
                    CodTipoColaborador_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Colaborador_Sector", x => x.OmitId);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    CodGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.CodGenero);
                });

            migrationBuilder.CreateTable(
                name: "SectorEmpresarial",
                columns: table => new
                {
                    CodSector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sector = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorEmpresarial", x => x.CodSector);
                });

            migrationBuilder.CreateTable(
                name: "TipoColaborador",
                columns: table => new
                {
                    CodTipoColaborador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colaborador = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoColaborador", x => x.CodTipoColaborador);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Detalle_Colaborador_Sector");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "SectorEmpresarial");

            migrationBuilder.DropTable(
                name: "TipoColaborador");
        }
    }
}
