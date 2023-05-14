using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin.Pages.Vacinas
{
    public class DeleteModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public DeleteModel(ImunoMeta.Server.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vacina Vacina { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Vacina == null)
            {
                return NotFound();
            }

            var vacina = await _context.Vacina.FirstOrDefaultAsync(m => m.Id == id);

            if (vacina == null)
            {
                return NotFound();
            }
            else 
            {
                Vacina = vacina;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Vacina == null)
            {
                return NotFound();
            }
            var vacina = await _context.Vacina.FindAsync(id);

            if (vacina != null)
            {
                Vacina = vacina;
                _context.Vacina.Remove(Vacina);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
