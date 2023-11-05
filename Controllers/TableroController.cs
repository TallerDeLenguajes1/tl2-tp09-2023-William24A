using Microsoft.AspNetCore.Mvc;
using RepoTableroU;
using UtilizarTablero;

namespace tl2_tp09_2023_William24A.Controllers;

[ApiController]
[Route("[controller]")]
public class TableroController : ControllerBase
{
    private readonly ILogger<TableroController> _logger;

    private IDtableroRepositorio repositorioTablero;
    public TableroController(ILogger<TableroController> logger)
    {
        _logger = logger;
        repositorioTablero = new RepoTableroC();
    }

    [HttpGet]
    [Route("Listar Tableros")]
    public ActionResult<List<Tablero>> ListarTableros()
    {
        var tableros = repositorioTablero.ListarTableros();
        return Ok(tableros);
    }

    [HttpGet]
    [Route("Listar Tableros por Usuario")]
    public ActionResult<List<Tablero>> ListarTablerosPorUsuario(int idUsuario)
    {
        var tableros = repositorioTablero.ListarTablerosUsuario(idUsuario);
        return Ok(tableros);
    }

     [HttpGet]
    [Route("Tablero por ID")]
    public ActionResult<Tablero> TableroPorID(int id)
    {
        var tablero = repositorioTablero.ObtenerTableroID(id);
        if(tablero.Id != null)
        {
            return Ok(tablero);
        }
        return NotFound("Recurso no encontrado");
    }

    [HttpPost("Crear")]
    public ActionResult<Tablero> CrearTablero(Tablero tablero)
    {
        repositorioTablero.CrearTablero(tablero);
        return Ok(tablero);
    }
     [HttpPut("Modificar Tablero")]
     public void ModificarTablero(int idTablero, Tablero tablero)
     {
        repositorioTablero.ModificarTablero(idTablero, tablero);
     }

     [HttpDelete("Eliminar Tablero")]
     public void EliminarTablero(int idTablero)
     {
        repositorioTablero.DeleteTablero(idTablero);
     }

}
