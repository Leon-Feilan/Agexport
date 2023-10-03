using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factura.Models
{
    public class Detalle_Factura_ProductoDetail
    {
        [Key]
        public int OmitId {  get; set; }

        [Column(TypeName = "int")]
        public int CodProducto_FK { get; set; }

        [Column(TypeName = "int")]
        public int CodFactura_FK { get; set; }

        [Column(TypeName = "int")]
        public int Cantidad { get; set; }

        [Column(TypeName = "int")]
        public int Total { get; set; }
    }
}
