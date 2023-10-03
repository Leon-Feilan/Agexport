using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Colaborador.Models
{
    public class Detalle_Colaborador_SectorDetail
    {
        [Key]
        public int OmitId { get; set; }

        [Column(TypeName = "int")]
        public int CodColaborador_FK { get; set; } = 0;


        [Column(TypeName = "int")]
        public int CodSector_FK { get; set; } = 0;

        [Column(TypeName = "int")]
        public int CodTipoColaborador_FK { get; set; } = 0;


    }
}
