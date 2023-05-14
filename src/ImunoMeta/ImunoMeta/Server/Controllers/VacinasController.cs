using ImunoMeta.Server.Interfaces;
using ImunoMeta.Shared.DTO;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImunoMeta.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacinasController : ControllerBase
    {
        private readonly IRepository<Vacina> _vacinaRepository;
        private readonly IRepository<UsuarioVacina> _usuarioVacinaRepository;

        public VacinasController(IRepository<Vacina> vacinaRepository, IRepository<UsuarioVacina> usuarioVacinaRepository)
        {
            _vacinaRepository = vacinaRepository;
            _usuarioVacinaRepository = usuarioVacinaRepository;
        }

        [HttpGet("ObterLista")]
        public async Task<IResult> ObterLista()
        {
            var lista = await _vacinaRepository._tableAsNoTracking.ToListAsync();
            return Results.Ok(lista);
        }

        [HttpPost("ObterListaPorUsuario")]
        public async Task<IResult> ObterLista(UsuarioDTO usuario)
        {
            Guid usuarioId;
            Guid.TryParse(usuario.Id, out usuarioId);

            var lista = await _usuarioVacinaRepository._tableAsNoTracking.Include(x => x.Vacina).Where(x => x.UsuarioId == usuarioId).ToListAsync();
            return Results.Ok(lista);
        }


    }
}
