using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BFBlog.Data;
using BFBlog.Data.Entities;

namespace BFBlog.Areas.Admin.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly BFBlog.Data.ApplicationDbContext _context;

        public IndexModel(BFBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categoria != null)
            {
                Categoria = await _context.Categoria.ToListAsync();
            }
        }
    }
}
