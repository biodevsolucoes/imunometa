using Microsoft.AspNetCore.Identity;

namespace ImunoMeta.Shared.Models
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; } = string.Empty;
        public string UrlFoto { get; set; } = string.Empty;
        public ICollection<Vacina>? Vacinas { get; set; }
    }
}