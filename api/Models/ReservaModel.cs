namespace api.models;

public class ReservaModel
{
    public int Id { get; set; }
    public DateTime Checkin { get; set; }
    public DateTime Checkout { get; set; }
    public DateTime CadastroEm { get; set; }
    public DateTime AtualizadoEm { get; set; }
    public String? Observacoes { get; set; }

    public int IdQuarto { get; set; }
    public QuartoModel Quarto { get; set; }
    public int IdUsuario { get; set; }
    public UsuarioModel Usuario { get; set; }
}