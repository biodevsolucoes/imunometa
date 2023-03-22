namespace ImunoMeta.Server.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Removido = false;
            DataCadastro = DateTime.Now;
            DataCadastroUTC = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataCadastroUTC { get; set; }
        public bool Removido { get; set; }
    }
}