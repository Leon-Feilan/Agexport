using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Colaborador.Models
{
    public class SectorEmpresarialDetail
    {

        [Key]
        public int CodSector { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Sector { get; set; } = "Secreto";
    }
}
