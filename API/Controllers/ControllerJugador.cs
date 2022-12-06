using Data;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerJugador : ControllerBase
{
    private readonly ServiceJugador servicioJugador;
    public ControllerJugador(ServiceJugador servicioJugador)
    {
        this.servicioJugador = servicioJugador;
    }

    [HttpPut("actualizarjugador")]
    public IActionResult ActualizarJugador(Jugador jugador)
    {
        if(jugador != null)
        {
            bool actualizo = servicioJugador.ActualizarJugador(jugador);
            if(actualizo)
                return Ok();
            else
                return BadRequest("Error al actualizar el jugador, intenta más tarde");
        }
        else
            return BadRequest("Corrobora los datos ingresados");
    }

    [HttpPost("agregarjugador")]
    public IActionResult AgregarJugador(Jugador jugador)
    {
        if(jugador != null)
        {
            bool actualizo = servicioJugador.AgregarJugador(jugador);
            if(actualizo)
                return Ok();
            else
                return BadRequest("Error al actualizar el jugador, intenta más tarde");
        }
        else
            return BadRequest("Corrobora los datos ingresados");
    }
}
