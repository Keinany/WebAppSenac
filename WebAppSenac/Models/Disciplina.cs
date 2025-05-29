using System.ComponentModel.DataAnnotations;

namespace WebAppSenac.Models
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeDisciplina { get; set; }
        [Required]
        [StringLength(100)]
        public string CargaHoraria { get; set; }
    }
}
