using System.ComponentModel.DataAnnotations;

namespace PetMatch.Models
{
    public class LoginViewModel
    {   
        [Required]
        public int? Nome { get; set; }

        [Required(ErrorMessage =" O Campo Email é obrigatório")]
        [EmailAddress(ErrorMessage ="Insira um endereço de email válido")]
        public string? Email { get; set; }

        [Required (ErrorMessage =" O campo senha é obrigatorio")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        public string? Token { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
        public string? ConfirmPassword { get; set; }
    }
}
