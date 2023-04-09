﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BFBlog.Data;
using BFBlog.Data.Entities;

namespace BFBlog.Areas.Admin.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly BFBlog.Data.ApplicationDbContext _context;

        public DetailsModel(BFBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Usuario Usuario { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            else 
            {
                Usuario = usuario;
            }
            return Page();
        }
    }
}
