namespace OfficeRoomie.Models.ViewModels;

public class ClienteReserva
{
    public Sala sala { get; set; }
    public Reserva reserva { get; set; }
    public Cliente cliente { get; set; }
    public List<Cartao> cartoes { get; set; } = new List<Cartao>();
}
