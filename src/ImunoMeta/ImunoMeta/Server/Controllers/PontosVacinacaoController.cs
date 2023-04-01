using ImunoMeta.Server.Interfaces;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImunoMeta.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontosVacinacaoController : ControllerBase
    {
        private readonly IRepository<PontoVacinacao> _pontosVacinacaoRepository;

        public PontosVacinacaoController(IRepository<PontoVacinacao> pontosVacinacaoRepository)
        {
            _pontosVacinacaoRepository = pontosVacinacaoRepository;
        }

        [HttpGet("Listar/{uf}/{quantidade}")]
        public async Task<IResult> Obter(string uf, int quantidade)
        {
            var pontosVacinacao = await _pontosVacinacaoRepository._tableAsNoTracking
                .Where(x => x.UF == uf)
                .Take(quantidade)
                .ToListAsync();
            return Results.Ok(pontosVacinacao);
        }

        [HttpGet("Imagem/{longitude}/{latitude}")]
        private string ObterImagem(double longitude, double latitude)
        {
            int zoom = 15;
            int width = 600;
            int height = 400;

            string url = $"";

            return $"{url}?width={width}&height={height}";
        }

        private int GetTileX(double longitude, int zoom)
        {
            return (int)((longitude + 180.0) / 360.0 * (1 << zoom));
        }

        private int GetTileY(double latitude, int zoom)
        {
            return (int)((1.0 - Math.Log(Math.Tan(latitude * Math.PI / 180.0) + 1.0 / Math.Cos(latitude * Math.PI / 180.0)) / Math.PI) / 2.0 * (1 << zoom));
        }
    }
}
