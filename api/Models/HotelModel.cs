namespace api.models;

public class HotelModel
{
    public int Id { get; set; }
    public required String Nome { get; set; } 
    public required String Localizacao { get; set; } 
    public required String Descricao { get; set; } 
    public String? Avaliacao { get; set; }
    public DateTime CadastroEm { get; set; }
    public DateTime AtualizadoEm { get; set; }

    public ICollection<QuartoModel> Quartos { get; }
    public ICollection<ImagemModel> Imagens { get; }
}