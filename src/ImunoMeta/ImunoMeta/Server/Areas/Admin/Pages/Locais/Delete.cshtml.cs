using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public DeleteModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public PontoVacinacao PontoVacinacao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.PontoVacinacao == null)
            {
                return NotFound();
            }

            var pontovacinacao = await _context.PontoVacinacao.FirstOrDefaultAsync(m => m.Id == id);

            if (pontovacinacao == null)
            {
                return NotFound();
            }
            else 
            {
                PontoVacinacao = pontovacinacao;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.PontoVacinacao == null)
            {
                return NotFound();
            }
            var pontovacinacao = await _context.PontoVacinacao.FindAsync(id);

            if (pontovacinacao != null)
            {
                PontoVacinacao = pontovacinacao;
                _context.PontoVacinacao.Remove(PontoVacinacao);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
