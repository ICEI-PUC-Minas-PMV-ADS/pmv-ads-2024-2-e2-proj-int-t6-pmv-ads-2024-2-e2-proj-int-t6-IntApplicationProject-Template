using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetMatch.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        [MaxLength(50)]
        public string? Raca { get; set; }

        [Required]
        public TipoPetEnum TipoPet { get; set; } // Enum para tipo de pet

        [Required]
        public SexoEnum Sexo { get; set; } // Enum para sexo

        [Required]
        public PorteEnum Porte { get; set; } // Enum para porte

        [Required]
        public byte[] Imagem { get; set; }
    }

    // Enums
    public enum TipoPetEnum { Cachorro, Gato, Outro }
    public enum SexoEnum { Macho, Fêmea }
    public enum PorteEnum { Pequeno, Médio, Grande }
}

