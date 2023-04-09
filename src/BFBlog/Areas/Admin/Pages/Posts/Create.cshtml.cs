using BFBlog.Data.Entities;
using BFBlog.Helpers;
using BFBlog.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BFBlog.Areas.Admin.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly BFBlog.Data.ApplicationDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly IArquivoService _arquivoService;

        public CreateModel(BFBlog.Data.ApplicationDbContext context, UserManager<Usuario> userManager, IArquivoService arquivoService)
        {
            _context = context;
            _userManager = userManager;
            _arquivoService = arquivoService;
        }

        public IActionResult OnGet()
        {
            Post = new Post()
            {
                DataPublicacao = DateTime.Now
            };

            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Nome");
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var usuario = await _userManager.GetUserAsync(User);

            if (usuario == null)
                return Page();

            if (Post.ImagemCapa != null)
                Post.ImagemCapaUrl = await _arquivoService.UploadArquivo(Post.ImagemCapa);

            Post.UsuarioId = usuario.Id;
            Post.SlugUrl = Post.Titulo.ToSlugUrl();


            if (!ModelState.IsValid || _context.Post == null || Post == null)
            {
                return Page();
            }

            _context.Post.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
