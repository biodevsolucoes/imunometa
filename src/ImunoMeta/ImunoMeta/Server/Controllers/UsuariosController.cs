using ImunoMeta.Shared.DTO;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ImunoMeta.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private SignInManager<Usuario> _signInManager;
        private UserManager<Usuario> _userManager;

        public UsuariosController(SignInManager<Usuario> signInManager, UserManager<Usuario> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("ObterUsuarioLogado")]
        public async Task<IResult> ObterUsuarioLogado(UsuarioDTO usuario)
        {
            var user = await _userManager.FindByEmailAsync(usuario.Email);
            if (usuario == null)
                return Results.NotFound();

            return Results.Ok(new UsuarioDTO
            {
                Nome = user.Nome,
                Email = user.Email,
                UrlAvatar = user.UrlFoto,
                Id = user.Id
            });
        }

        [HttpGet("Obter/{id}")]
        public async Task<IResult> Obter(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return Results.NotFound();

            return Results.Ok(new UsuarioDTO
            {
                Nome = user.Nome,
                Email = user.Email,
                UrlAvatar = user.UrlFoto,
                Id = user.Id
            });
        }

    }
}
