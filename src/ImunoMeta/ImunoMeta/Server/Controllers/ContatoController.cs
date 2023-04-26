using ImunoMeta.Shared.DTO;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImunoMeta.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private SignInManager<Usuario> _signInManager;
        private UserManager<Usuario> _userManager;

        public ContatoController(SignInManager<Usuario> signInManager, UserManager<Usuario> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet("Obter")]
        public async Task<IResult> Obter()
        {
            try
            {
                var users = await _userManager.Users.Select(user => new UsuarioDTO
                {
                    Nome = user.Nome,
                    Email = user.Email,
                    UrlAvatar = user.UrlFoto,
                    Id = user.Id
                }).OrderBy(x => x.Nome).ToListAsync();

                return
                Results.Ok(users);
            }
            catch (Exception e)
            {
                return Results.Empty;
            }
        }

    }
}
