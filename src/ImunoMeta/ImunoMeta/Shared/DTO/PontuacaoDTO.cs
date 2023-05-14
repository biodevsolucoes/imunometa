namespace ImunoMeta.Shared.DTO
{
    public class PontuacaoDTO
    {
        public int totalPontos { get; set; }
        public int totalTrofeus { get; set; }
        public IEnumerable<PontoDTO> HistoricoPontuacao { get; set; }
    }

    public class PontoDTO
    {
        public int Valor { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
    }
}
