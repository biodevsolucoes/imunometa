using BFBlog.Data.Entities;
using BFBlog.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BFBlog.Areas.Admin.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Post> _postRepository;

        public IEnumerable<Post> Posts { get; set; }

        public IndexModel(IRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task OnGetAsync()
        {
            Posts = await _postRepository._tableAsNoTracking.ToListAsync();
        }
    }
}
