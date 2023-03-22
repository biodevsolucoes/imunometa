namespace ImunoMeta.Server.Models
{
    public class Noticia : BaseModel
    {
        public string Titulo { get; set; } = string.Empty;
        public string Resumo { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
        public string UrlImagemCapa { get; set; } = string.Empty;

    }
}