namespace ImunoMeta.Server.Models
{
    public class Denuncia : BaseModel
    {
        public string Descricao { get; set; } = string.Empty;
        public string UrlDenunciada { get; set; } = string.Empty;
        public Guid UsuarioId { get; set; }

        public Usuario Usuario { get; set; } = new();
    }
}