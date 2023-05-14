using ImunoMeta.Server.Interfaces;
using ImunoMeta.Shared.DTO;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImunoMeta.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontuacoesController : ControllerBase
    {
        private readonly IRepository<Pontuacao> _pontuacaoRepository;

        public PontuacoesController(IRepository<Pontuacao> pontuacaoRepository)
        {
            _pontuacaoRepository = pontuacaoRepository;
        }

        [HttpPost("ObterPorUsuario")]
        public async Task<IResult> ObterPontuacao(UsuarioDTO usuario)
        {
            Guid usuarioId;
            Guid.TryParse(usuario.Id, out usuarioId);

            var pontos = _pontuacaoRepository._tableAsNoTracking.Where(x => x.UsuarioId == usuarioId).Include(x => x.Usuario).Include(x => x.TipoPontuacao).ToList();
            decimal totalPontos = pontos.Where(x => x.TipoPontuacao != null).Sum(x => x.TipoPontuacao.Valor);
            decimal trofeus = Math.Floor(totalPontos / 100);

            return Results.Ok(new PontuacaoDTO
            {
                totalPontos = (int)pontos.Sum(x => x.TipoPontuacao.Valor),
                totalTrofeus = (int)trofeus,
                HistoricoPontuacao = pontos.Select(x => new PontoDTO
                {
                    Descricao = x.TipoPontuacao.Descricao,
                    Data = x.TipoPontuacao.DataCadastro.ToString("dd/MM/yyyy"),
                    Valor = x.TipoPontuacao.Valor
                })
            });
        }

    }
}
