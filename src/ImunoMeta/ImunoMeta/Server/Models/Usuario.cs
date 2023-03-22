using Microsoft.AspNetCore.Identity;

namespace ImunoMeta.Server.Models
{
    public class Usuario : IdentityUser<Guid>
    {
        public string Nome { get; set; } = string.Empty;
        public string UrlFoto { get; set; } = string.Empty;
        public ICollection<Vacina>? Vacinas { get; set; }
    }
}