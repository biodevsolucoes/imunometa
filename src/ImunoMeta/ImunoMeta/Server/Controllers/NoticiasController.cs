using ImunoMeta.Server.Interfaces;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImunoMeta.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoticiasController : ControllerBase
    {
        private readonly IRepository<Noticia> _noticiaRepository;

        public NoticiasController(IRepository<Noticia> noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        [HttpGet("Recentes/{quantidade}")]
        public async Task<IResult> ObterRecentes(int quantidade = 10)
        {
            if (quantidade > 20)
                return Results.BadRequest();

            var noticias = await _noticiaRepository.ObterLista(0, quantidade);
            noticias = noticias.OrderByDescending(x => x.DataCadastro);

            return Results.Ok(noticias);
        }
    }
}
