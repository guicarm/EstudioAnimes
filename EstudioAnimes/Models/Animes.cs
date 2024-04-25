using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioAnime.Models
{
    [Table("98874_Animes")]
    public class Animes
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimesId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Preencha o campo QuantidadeEp")]
        public int QuantidadeEp { get; set; }

        [Required(ErrorMessage = "Preencha o campo DataLançamento")]
        public string DataLancamento{ get; set; }

}

}
