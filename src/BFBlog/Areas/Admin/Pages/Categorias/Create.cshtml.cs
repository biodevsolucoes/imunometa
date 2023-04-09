using BFBlog.Data.Entities;
using BFBlog.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BFBlog.Areas.Admin.Pages.Categorias
{
    public class CreateModel : PageModel
    {
        private readonly BFBlog.Data.ApplicationDbContext _context;

        public CreateModel(BFBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Categoria Categoria { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Categoria.SlugUrl = Categoria.Nome.ToSlugUrl();

            if (!ModelState.IsValid || _context.Categoria == null || Categoria == null)
            {
                return Page();
            }

            _context.Categoria.Add(Categoria);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
