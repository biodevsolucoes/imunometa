using System.ComponentModel.DataAnnotations;

namespace BFBlog.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Removido { get; set; } = false;
    }
}
