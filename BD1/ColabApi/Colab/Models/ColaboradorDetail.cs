using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colaborador.Models
{
    public class ColaboradorDetail
    {
        [Key]
        public int CodColaborador { get; set; }

        [Column(TypeName = "bigint")]
        public int Dpi { get; set; } = 0;

        [Column(TypeName = "varchar(30)")]
        public string Nombre_1 { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string Nombre_2 { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string Apellido_1 { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string Apellido_2 { get; set; } = "";

        [Column(TypeName = "int")]
        public int CodGenero_FK { get; set; } = 0;

        [Column(TypeName = "varchar(12)")]
        public string FechaDeNacimiento { get; set; } = "1999-01-20";

        [Column(TypeName = "int")]
        public int Telefono { get; set; } = 0;

        [Column(TypeName = "varchar(100)")]
        public string Direccion { get; set; } = "";




    }
}
