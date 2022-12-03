using Data;
using Microsoft.AspNetCore.Mvc;
using Model.View;
using Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerEquipo : ControllerBase
{
    private readonly ServicioEquipo servicioEquipo;
    public ControllerEquipo(ServicioEquipo servicioEquipo)
    {
        this.servicioEquipo = servicioEquipo;
    }

    [HttpGet("obtenerEquipo{nombreEquipo}")]
    public IActionResult obtenerEquipo(string nombreEquipo)
    {

        if(nombreEquipo != null)
        {
            ViewModelEquipo vistaEquipo;
            Equipo equipo = servicioEquipo.ObtenerEquipo(nombreEquipo);
            if(equipo != null)
            {
                vistaEquipo = new ViewModelEquipo();
                return Ok(vistaEquipo.RetornarVistaEquipo(equipo)); 
            }else 
                return NotFound();
        }else
            return BadRequest();
    } 
}
