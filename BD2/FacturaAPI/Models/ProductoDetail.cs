using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using System.Data;

namespace Factura.Models
{
    public class ProductoDetail
    {
        [Key]
        public int CodProducto {  get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; } = " ";

        [Column(TypeName = "int")]
        public int Stock { get; set; } = 0;

        [Column(TypeName = "int")]
        public int Precio { get; set; } = 0;
        


    }
}
