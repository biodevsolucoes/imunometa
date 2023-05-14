using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin.Pages.PontuacaoUsuario
{
    public class IndexModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public IndexModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Pontuacao> Pontuacao { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pontuacao != null)
            {
                Pontuacao = await _context.Pontuacao
                .Include(p => p.TipoPontuacao).ToListAsync();
            }
        }
    }
}
