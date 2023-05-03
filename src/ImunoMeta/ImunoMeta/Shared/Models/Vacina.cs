namespace ImunoMeta.Shared.Models
{
    public class Vacina : BaseModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string CssClass { get; set; } = string.Empty;
    }
}