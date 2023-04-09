namespace BFBlog.Data.Entities
{
    public class Categoria : BaseEntity
    {

        public string Nome { get; set; } = string.Empty;
        public string SlugUrl { get; set; } = string.Empty;
        public Categoria()
        {

        }

        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}
