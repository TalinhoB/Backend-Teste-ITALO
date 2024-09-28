using Microsoft.AspNetCore.Mvc;
using SistemaListagem.Data;
using SistemaListagem.Models;
using SistemaListagem.Repositorios.Interfaces;

namespace SistemaListagem.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly BancoContext _bancoContext;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(BancoContext bancoContext, IUsuarioRepositorio usuarioRepositorio)
        {
            _bancoContext = bancoContext;
            _usuarioRepositorio = usuarioRepositorio;
        }
        [HttpPost("Criar")]
        public async Task <IActionResult> GravarUsuario([FromBody] List<Usuarios> dados)
        {
            var gravar = await _usuarioRepositorio.GravarUsuario(dados);

            if (gravar)
            {
                return Ok();
            }
            return BadRequest("Não gravou");
        }
    }
}
