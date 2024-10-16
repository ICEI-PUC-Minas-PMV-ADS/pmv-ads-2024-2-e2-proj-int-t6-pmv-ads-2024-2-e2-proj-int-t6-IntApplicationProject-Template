using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockUp.Models
{
    [Table("Entradas")]
    public class Entrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Produto é obrigatório")]
        [Display(Name = "Produto")]
        public Guid ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public required Produto Produto { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatório")]
        public int Quantidade { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Criado em") ]
        public DateTime CriadoEm { get; set; }
    }
}
