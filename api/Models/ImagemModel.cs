namespace api.models;

public class ImagemModel
{
    public int Id { get; set; }
    public required String Imagem { get; set; } 
    public DateTime CadastroEm { get; set; }
    public DateTime AtualizadoEm { get; set; }

    public int IdHotel { get; set; }
    public HotelModel Hotel { get; set; }
}