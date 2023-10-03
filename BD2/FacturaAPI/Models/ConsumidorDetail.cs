using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using System.Data;

namespace Factura.Models
{
    public class ConsumidorDetail
    {
        [Key]

        public int CodConsumidor {  get; set; }

        [Column(TypeName = "bigint")]
        public int Nit {  get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string Apellido { get; set; } = "";
    }
}
