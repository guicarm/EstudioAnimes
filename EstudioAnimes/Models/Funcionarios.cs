using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioAnime.Models
{
    [Table("98874_Funcionario")]
    public class Funcionarios 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        protected string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cargo")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Salario")]
        public double Salario { get; set; }

        [Required(ErrorMessage = "Preencha o campo Idade")]
        public int Idade { get; set; }

      
    }
}
