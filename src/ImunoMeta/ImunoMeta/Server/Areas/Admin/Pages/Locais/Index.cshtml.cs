using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ImunoMeta.Server.Areas.Admin
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public IndexModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PontoVacinacao> PontoVacinacao { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PontoVacinacao != null)
            {
                PontoVacinacao = await _context.PontoVacinacao.ToListAsync();
            }
        }
    }
}
