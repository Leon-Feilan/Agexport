using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Factura.Models
{
    public class FacturaDetail
    {
        //primary key
        [Key]
        public int CodFactura {  get; set; }

        [Column(TypeName="int")]
        public int CodConsumidor_FK { get; set; } = 0;

        [Column(TypeName = "varchar(10)")]
        public string Fecha { get; set; } = "2023-09-30";


    }
}
