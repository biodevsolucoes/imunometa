using BFBlog.Data.Entities;
using BFBlog.Helpers;
using BFBlog.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BFBlog.Areas.Admin.Pages.Posts
{
    public class EditModel : PageModel
    {
        private readonly BFBlog.Data.ApplicationDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly IArquivoService _arquivoService;

        public EditModel(BFBlog.Data.ApplicationDbContext context, UserManager<Usuario> userManager, IArquivoService arquivoService)
        {
            _context = context;
            _userManager = userManager;
            _arquivoService = arquivoService;
        }

        [BindProperty]
        public Post Post { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Post == null)
            {
                return NotFound();
            }

            var post =  await _context.Post.FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            Post = post;
           ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id");
           ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (Post.ImagemCapa != null)
                Post.ImagemCapaUrl = await _arquivoService.UploadArquivo(Post.ImagemCapa);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(Post.Id))
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

        private bool PostExists(Guid id)
        {
          return (_context.Post?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
