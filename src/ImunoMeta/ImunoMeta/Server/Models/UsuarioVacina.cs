namespace ImunoMeta.Server.Models
{
    public class UsuarioVacina : BaseModel
    {
        public Guid UsuarioId { get; set; }
        public virtual Guid VacinaId { get; set; }
        public virtual Usuario Usuario { get; set; } = new();
        public Vacina Vacina { get; set; } = new();
    }
}