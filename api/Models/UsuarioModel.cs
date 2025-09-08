using System.Runtime.ConstrainedExecution;

namespace api.models;

public class UsuarioModel
{
    public int Id { get; set; }
    public required String Nome { get; set; } 
    public required String Cpf { get; set; }
    public required String Email { get; set; }
    public required String Senha { get; set; } 
    public required String Telefone { get; set; } 
    public DateTime CadastroEm { get; set; }
    public DateTime AtualizadoEm { get; set; }

    public ICollection<ReservaModel> Reservas { get; }
}