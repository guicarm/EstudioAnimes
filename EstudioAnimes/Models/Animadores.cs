using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioAnime.Models
{
    [Table("98874_Animadores")]

    public class Animadores 

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimadoresId { get; set; }

        public string EstiloAnimacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo AnosExperiência")]
        public int AnosExperiencia { get; set; }

    }

}