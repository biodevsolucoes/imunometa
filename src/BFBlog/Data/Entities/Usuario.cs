using Microsoft.AspNetCore.Identity;

namespace BFBlog.Data.Entities
{
    public class Usuario : IdentityUser<Guid>
    {
        public string Nome { get; set; } = string.Empty;
        public string FotoUrl { get; set; } = string.Empty;
    }

    public class Roles : IdentityRole<Guid>
    {

    }
}
