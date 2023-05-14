using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ImunoMeta.Server.Areas.Admin.Pages.Vacinas
{
    public class IndexModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public IndexModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Vacina> Vacina { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Vacina != null)
            {
                Vacina = await _context.Vacina.ToListAsync();
            }
        }
    }
}
