using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeRoomie.Models;

[Table("reservas")]
public class Reserva

{
    [Key]
    public int id { get; set; }
    [Required]
    [Display(Name="Hora Início")]
    public string hora_inicio { get; set; } = "";
    [Required]
    [Display(Name="Hora Fim")]
    public string hora_fim { get; set; } = "";
    [Required]
    [Display(Name="Data da Reserva")]
    public string data_reserva { get; set; } = "";
    [Required]
    [Display(Name="Protocolo")]
    public string protocolo { get; set; } = "";
    [Required]
    [Display(Name="Status")]
    public string status { get; set; } = "";
    [Required]
    public int cliente_id { get; set; }
    [Required]
    public int sala_id { get; set; }
    [Required]
    public int cartão_id { get; set; }

    public Cliente? cliente { get; set; }
    public Sala? sala { get; set; }
    public Cartao? cartao { get; set; }


    public string? created_at { get; set; } = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
    public string? updated_at { get; set; } = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";

}
