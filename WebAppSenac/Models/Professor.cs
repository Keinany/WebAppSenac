using System.ComponentModel.DataAnnotations;

namespace WebAppSenac.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Disciplina { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }

    }
}
