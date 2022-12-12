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

    [HttpDelete("eliminarJugador{id}")]
    public IActionResult EliminarJugador(string id)
    {
        if(id != null)
        {
            int swEliminado = servicioJugador.Eliminarjugador(id);
            switch (swEliminado)
            {
                case 0:
                    return BadRequest("Hubo un error, reintenta");
                case 1:
                    return Ok("Jugador eliminado exitosamente del equipo");
                case -1:
                    return NotFound("No se encontró al jugador");
                case -2:
                    return BadRequest("Error");
                default:
                    return BadRequest("Error");
            }
        }else
            return BadRequest("Verifica al jugador");
    }
}
