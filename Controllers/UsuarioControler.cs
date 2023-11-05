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
    [Route("Todos los Usuarios")]
    public ActionResult<List<Usuario>> TodosLosUsuarios()
    {
        var usuarios = repositorioUsuario.GetAll();
        if(usuarios != null)
        {
            return Ok(usuarios);
        }
        return NotFound("Recurso no encontrado");
    }

    [HttpGet]
    [Route("Buscar usuario por ID")]
    public ActionResult<Usuario> DetallesUsuPorId(int idUsuario)
    {
        var usuario = repositorioUsuario.GetById(idUsuario);
        if(usuario.Id != null)
        {
            return Ok(usuario);
        }
        return NotFound("Recursos no encontrado");
    }

    [HttpPost("Crear")]
    public ActionResult<Usuario> CrearUsuario(Usuario usuario)
    {
        repositorioUsuario.Create(usuario);
        return Ok(usuario);
    }

    [HttpPut("Modificar Usuario")]
    public ActionResult<Usuario> ModificarUsuario(int idUsuario, Usuario usuario)
    {
        repositorioUsuario.Update(idUsuario, usuario);
        return Ok(usuario);
    }


    [HttpDelete("Eliminar usuario")]
    public ActionResult<string> EliminarUsuario(int id)
    {
        repositorioUsuario.Remove(id);
        return Ok("Se elimino");
    }
    

}
