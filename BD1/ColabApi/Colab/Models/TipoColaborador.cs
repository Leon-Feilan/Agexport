using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Colaborador.Models
{
    public class TipoColaborador
    {
        [Key]
        public int CodTipoColaborador { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Colaborador { get; set; } = "";

    }
}
