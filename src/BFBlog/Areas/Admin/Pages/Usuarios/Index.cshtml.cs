using System;
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
    public class IndexModel : PageModel
    {
        private readonly BFBlog.Data.ApplicationDbContext _context;

        public IndexModel(BFBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Usuario != null)
            {
                Usuario = await _context.Usuario.ToListAsync();
            }
        }
    }
}
