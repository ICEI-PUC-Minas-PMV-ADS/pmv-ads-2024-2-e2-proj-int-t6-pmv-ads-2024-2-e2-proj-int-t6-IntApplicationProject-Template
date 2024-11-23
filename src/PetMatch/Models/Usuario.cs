using System.ComponentModel.DataAnnotations;

namespace PetMatch.Models
{
    public class Usuario
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Senha { get; set; }
    }
}
