using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockUp.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CriadoEm { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AtualizadoEm { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
