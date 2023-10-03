using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colaborador.Models
{
    public class GeneroDetail
    {
        [Key]
        public int CodGenero {  get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Genero { get; set; } = "Secreto";


    }
}
