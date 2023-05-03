using ImunoMeta.Server.Interfaces;
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

        public VacinasController(IRepository<Vacina> vacinaRepository)
        {
            _vacinaRepository = vacinaRepository;
        }

        [HttpGet("ObterLista")]
        public async Task<IResult> ObterLista()
        {
            var lista = await _vacinaRepository._tableAsNoTracking.ToListAsync();
            return Results.Ok(lista);
        }


    }
}
