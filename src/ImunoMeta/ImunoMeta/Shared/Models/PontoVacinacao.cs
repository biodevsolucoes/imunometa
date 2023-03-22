namespace ImunoMeta.Shared.Models
{
    public class PontoVacinacao : BaseModel
    {
        public Guid? UsuarioId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Cidade { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;

        public virtual Usuario? Usuario { get; set; }
    }
}