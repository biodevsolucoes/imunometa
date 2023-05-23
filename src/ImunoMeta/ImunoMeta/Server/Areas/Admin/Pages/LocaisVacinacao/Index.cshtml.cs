using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin.Pages.LocaisVacinacao
{
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
