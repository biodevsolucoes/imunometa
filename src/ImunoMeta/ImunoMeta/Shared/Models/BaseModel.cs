using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImunoMeta.Shared.Models
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataCadastroUTC { get; set; }
        public bool Removido { get; set; }

        public void Excluir() => this.Removido = false;
    }
}