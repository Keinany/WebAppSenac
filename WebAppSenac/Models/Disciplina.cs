using System.ComponentModel.DataAnnotations;

namespace WebAppSenac.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeDisciplina { get; set; }
        [Required]
        [StringLength(100)]
        public string CargaHoraria { get; set; }
    }
}
