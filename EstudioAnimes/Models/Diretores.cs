using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioAnime.Models
{
    [Table("98874_Diretores")]
    public class Diretores 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiretoresId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Especialização")]
        public string Especializacao { get; set; }

        public int ProjetosConcluidos { get; set; }

    }

      
}
