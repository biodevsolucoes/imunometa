using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin.Pages.PontuacaoUsuario
{
    public class EditModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public EditModel(ImunoMeta.Server.Data.ApplicationDbContext context)
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

            var pontuacao =  await _context.Pontuacao.FirstOrDefaultAsync(m => m.Id == id);
            if (pontuacao == null)
            {
                return NotFound();
            }
            Pontuacao = pontuacao;
           ViewData["TipoPontuacaoId"] = new SelectList(_context.TipoPontuacao, "Id", "Descricao");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pontuacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PontuacaoExists(Pontuacao.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PontuacaoExists(Guid id)
        {
          return (_context.Pontuacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
