namespace ImunoMeta.Shared.Models
{
    public class Mensagem : BaseModel
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } = new();
        public string Texto { get; set; } = string.Empty;
        public Guid UsuarioDestinoId { get; set; }
        public virtual Usuario UsuarioDestino { get; set; }
    }
}