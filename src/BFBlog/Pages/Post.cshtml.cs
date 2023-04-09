using BFBlog.Data.Entities;
using BFBlog.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BFBlog.Pages
{
    public class PostModel : PageModel
    {
        private readonly IRepository<Post> _postRepository;

        public PostModel(IRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public Post Post { get; set; }

        public async Task OnGetAsync(string slug)
        {
            Post = await _postRepository._tableAsNoTracking.Include(x => x.Usuario).Include(x => x.Categoria).FirstOrDefaultAsync(x => x.SlugUrl == slug);
        }
    }
}
