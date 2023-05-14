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
    public class DetailsModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public DetailsModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
