namespace ImunoMeta.Server.Models
{
    public class TipoPontuacao : BaseModel
    {
        public string Descricao { get; set; } = string.Empty;
        public virtual int Valor { get; set; }
    }
}