using Data;
using Microsoft.AspNetCore.Mvc;
using Model.View;
using Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerJugador : ControllerBase
{
    private readonly ServiceJugador servicioJugador;
    private readonly ServicePersona servicePersona;
    public ControllerJugador(ServiceJugador servicioJugador, ServicePersona servicePersona)
    {
        this.servicioJugador = servicioJugador;
        this.servicePersona = servicePersona;
    }

    [HttpPut("actualizarjugador")]
    public IActionResult ActualizarJugador(ViewModelJugador jugador)
    {
        if (jugador != null)
        {
            bool actualizo = servicioJugador.ActualizarJugador(jugador);
            if (actualizo)
            {
                actualizo = servicePersona.ActualizarDatos(jugador);
                if (actualizo)
                    return Ok("Se actualizó con éxito los datos");
                else
                    return BadRequest("Error al actualizar el jugador");
            }
            else
                return BadRequest("Error al actualizar el jugador, intenta más tarde");
        }
        else
            return BadRequest("Corrobora los datos ingresados");
    }

    [HttpPost("agregarjugador")]
    public IActionResult AgregarJugador(ViewModelJugador jugador)
    {
        if (jugador != null)
        {
            Persona personaAgregada = servicePersona.AgregarPersona(jugador);
            if (personaAgregada != null)
            {
                Jugador jugadorAgregado = servicioJugador.AgregarJugador(jugador);
                if (jugadorAgregado != null)
                    return Ok(jugador);
                else
                    return BadRequest("Verifica los datos ingresados");
            }
            else
                return BadRequest("Error al actualizar el jugador, intenta más tarde");
        }
        else
            return BadRequest("Corrobora los datos ingresados");
    }
}
