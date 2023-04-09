using System.ComponentModel.DataAnnotations.Schema;

namespace BFBlog.Data.Entities
{
    public class Post : BaseEntity
    {
        public string Titulo { get; set; } = string.Empty;
        public string Resumo { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;

        public Guid UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }

        [NotMapped]
        public IFormFile? ImagemCapa { get; set; }

        public string? ImagemCapaUrl { get; set; }
        public DateTime? DataPublicacao { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

        public string Tags { get; set; } = string.Empty;
        public string SlugUrl { get; set; } = string.Empty;
    }
}
