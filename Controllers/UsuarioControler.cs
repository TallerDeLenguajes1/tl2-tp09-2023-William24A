using Microsoft.AspNetCore.Mvc;
using RepoUsuarioU;
using UtilizarUsuario;

namespace tl2_tp09_2023_William24A.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ILogger<UsuarioController> _logger;

    private IDUsuarioRepository repositorioUsuario;
    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
        repositorioUsuario = new RepoUsuarioC();
    }

    [HttpGet]
    [Route("Crear")]
    public ActionResult<Usuario> CrearUsuario(Usuario usuario)
    {
        repositorioUsuario.Create(usuario);
        return Ok(usuario);
    }
    
    

}
