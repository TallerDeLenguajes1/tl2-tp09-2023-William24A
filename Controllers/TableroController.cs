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

    [HttpPost("Crear")]
    public ActionResult<Tablero> CrearTablero(Tablero tablero)
    {
        repositorioTablero.CrearTablero(tablero);
        return Ok(tablero);
    }
    
    

}
