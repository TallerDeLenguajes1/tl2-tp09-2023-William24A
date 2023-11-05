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
    [HttpGet]
    [Route("Obtener tareas por ID tablero")]
    public ActionResult<List<Tarea>> ObtenerTareasIDTablero(int idTablero)
    {
        var tareas = repositorioTarea.BuscarTareasTablero(idTablero);
        return Ok(tareas);
    }

    [HttpGet]
    [Route("Buscar Tarea por ID")]
    public ActionResult<Tarea> BuscarTareaID(int Id)
    {
        var tarea = repositorioTarea.BuscarPorId(Id);
        if(tarea.Id != null)
        {
            return Ok(tarea);
        }
        return NotFound("Recurso no encontrado");
    }

    [HttpPost("Crear Tarea")]
    public ActionResult<Tarea> CrearTarea(Tarea tarea)
    {
        var tareaN = repositorioTarea.CreaTarea(tarea);
        if(tareaN != null)
        {
            return Created("",tareaN);
        } 
        return BadRequest("No se creo la tarea");
    }
    
    [HttpPut("Asignar Usuario a Tarea")]
    public void AsignarUsuTarea(int idUsuario, int idTarea)
    {
        repositorioTarea.AsignarUsuTarea(idUsuario, idTarea);
    }

    [HttpPut("Modificar tarea")]
    public void ModificarTarea(int idtarea, Tarea tarea)
    {
        repositorioTarea.Modificar(idtarea, tarea);
    }

    [HttpDelete("Eliminar tarea")]
    public void Eliminartarea(int idTarea)
    {
        repositorioTarea.DeleteTarea(idTarea);
    }

}
