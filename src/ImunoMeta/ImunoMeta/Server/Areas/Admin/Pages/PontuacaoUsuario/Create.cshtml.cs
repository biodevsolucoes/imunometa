using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin.Pages.PontuacaoUsuario
{
    public class CreateModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public CreateModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TipoPontuacaoId"] = new SelectList(_context.TipoPontuacao, "Id", "Descricao");
            return Page();
        }

        [BindProperty]
        public Pontuacao Pontuacao { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pontuacao == null || Pontuacao == null)
            {
                return Page();
            }

            _context.Pontuacao.Add(Pontuacao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
