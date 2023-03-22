namespace ImunoMeta.Server.Models
{
    public class Pontuacao : BaseModel
    {
        public Guid UsuarioId { get; set; }
        public Guid TipoPontuacaoId { get; set; }
        public virtual Usuario Usuario { get; set; } = new();

        public virtual TipoPontuacao TipoPontuacao { get; set; } = new();
    }
}