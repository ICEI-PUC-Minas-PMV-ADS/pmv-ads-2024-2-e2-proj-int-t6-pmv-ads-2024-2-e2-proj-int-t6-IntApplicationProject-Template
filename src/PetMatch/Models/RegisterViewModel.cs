using System.ComponentModel.DataAnnotations;

namespace PetMatch.Models
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage =" O Campo Nome é obrigatorio")]
        public int? Nome { get; set; }

        [Required (ErrorMessage ="O campo Email é obrigatório")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
        public string? ConfirmPassword { get; set; }
    }
}
