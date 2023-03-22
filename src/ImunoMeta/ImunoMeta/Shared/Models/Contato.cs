namespace ImunoMeta.Shared.Models
{
    public class Contato : BaseModel
    {
        public Guid UsuarioId { get; set; }
        public Guid UsuarioContatoId { get; set; }
        public virtual Usuario Usuario { get; set; } = new();
        public virtual Usuario UsuarioContato { get; set; } = new();
    }
}