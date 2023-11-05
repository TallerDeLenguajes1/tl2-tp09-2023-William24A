using RepoTareaU;
using UtilizarTarea;
using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_William24A.Controllers;

[ApiController]
[Route("[controller]")]
public class TareaController : ControllerBase
{
    private readonly ILogger<TareaController> _logger;

    private IDTareaRepositorio repositorioTarea;
    public TareaController(ILogger<TareaController> logger)
    {
        _logger = logger;
        repositorioTarea = new RepoTareaC();
    }

    [HttpGet]
    [Route("Obtener tareas por ID usuario")]
    public ActionResult<List<Tarea>> ObtenerTareasID(int idUsuario)
    {
        var tareas = repositorioTarea.BuscarTodasTarea(idUsuario);
        return Ok(tareas);
    }
    [HttpPost("Crear")]
    public ActionResult<Tarea> CrearTarea(Tarea tarea)
    {
        var tareaN = repositorioTarea.CreaTarea(tarea);
        if(tareaN != null)
        {
            return Created("",tareaN);
        } 
        return BadRequest("No se creo la tarea");
    }
    
    

}
