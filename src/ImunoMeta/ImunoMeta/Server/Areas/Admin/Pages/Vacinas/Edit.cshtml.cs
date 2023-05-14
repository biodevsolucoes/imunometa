﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImunoMeta.Server.Data;
using ImunoMeta.Shared.Models;

namespace ImunoMeta.Server.Areas.Admin.Pages.Vacinas
{
    public class EditModel : PageModel
    {
        private readonly ImunoMeta.Server.Data.ApplicationDbContext _context;

        public EditModel(ImunoMeta.Server.Data.ApplicationDbContext context)
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

            var vacina =  await _context.Vacina.FirstOrDefaultAsync(m => m.Id == id);
            if (vacina == null)
            {
                return NotFound();
            }
            Vacina = vacina;
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

            _context.Attach(Vacina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VacinaExists(Vacina.Id))
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

        private bool VacinaExists(Guid id)
        {
          return (_context.Vacina?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
