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
    public class DeleteModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public DeleteModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Pontuacao Pontuacao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Pontuacao == null)
            {
                return NotFound();
            }

            var pontuacao = await _context.Pontuacao.FirstOrDefaultAsync(m => m.Id == id);

            if (pontuacao == null)
            {
                return NotFound();
            }
            else 
            {
                Pontuacao = pontuacao;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Pontuacao == null)
            {
                return NotFound();
            }
            var pontuacao = await _context.Pontuacao.FindAsync(id);

            if (pontuacao != null)
            {
                Pontuacao = pontuacao;
                _context.Pontuacao.Remove(Pontuacao);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
