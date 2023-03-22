namespace ImunoMeta.Server.Models
{
    public class UsuarioTrofeu : BaseModel
    {
        public Guid UsuarioId { get; set; }
        public Guid TrofeuId { get; set; }
        public virtual Usuario Usuario { get; set; } = new();
        public virtual Trofeu Trofeu { get; set; } = new();
    }
}