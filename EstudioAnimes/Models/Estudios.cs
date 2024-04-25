using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioAnime.Models
{
    [Table("98874_Estudios")]
    public class Estudios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstudiosId { get; set; }

        [Required(ErrorMessage = "Preencha o campo NomeEstudio")]
        public string NomeEstudio { get; set; }

        [Required(ErrorMessage = "Preencha o campo País")]
        public string Pais { get; set; }

        public string DataFundação { get; set; }

    }
}
