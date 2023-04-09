using BFBlog.Data.Entities;
using BFBlog.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BFBlog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository<Post> _postRepository;

        public IndexModel(ILogger<IndexModel> logger, IRepository<Post> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public IEnumerable<Post> Posts { get; set; }

        public async Task OnGetAsync()
        {
            Posts = await _postRepository._tableAsNoTracking
                                        .Include(x => x.Categoria)
                                        .Include(x => x.Usuario)
                                        .OrderByDescending(x => x.DataPublicacao)
                                        .Take(20).ToListAsync();
        }
    }
}