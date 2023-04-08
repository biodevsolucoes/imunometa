namespace BFBlog.Data.Entities
{
    public class Categoria : BaseEntity
    {

        public string Nome { get; private set; } = string.Empty;

        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}
