namespace api.models;

public class QuartoModel
{
    public int Id { get; set; }
    public required String TipoQuarto { get; set; }
    public int Capacidade { get; set; }
    public float Preco { get; set; }
    public bool Disponivel { get; set; }
    public DateTime CadastroEm { get; set; }
    public DateTime AtualizadoEm { get; set; }

    public int IdHotel { get; set; }
    public HotelModel Hotel { get; set; }
    

    public ICollection<ReservaModel> Reservas { get; }

}