using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeRoomie.Models
{
    [Table("Cancelamentos")] 

    public class Cancelamento
    {
        [Required(ErrorMessage ="Obrigatório informar o nome")]
        public required string Nome { get; set; }

        public int Data { get; set; }

        public int Horario { get; set; }


    }
}
