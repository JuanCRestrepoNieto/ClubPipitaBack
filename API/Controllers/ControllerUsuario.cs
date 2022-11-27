using Data;
using Microsoft.AspNetCore.Mvc;
using Model.View;
using Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerUsuario : ControllerBase
{
    protected readonly ServiceUsuario serviceUsuario;
    public ControllerUsuario(ServiceUsuario servicioUsuario)
    {
        this.serviceUsuario = servicioUsuario;
    }
    
    [HttpPost ("iniciarSesion")]
    public IActionResult obtenerUsuario(ViewModelLogin usuario){
        Usuario user = serviceUsuario.ValidarLogin(usuario.Correo, usuario.Contarsena); 
        if(user != null)
        {
            ViewModelUsuario vistaModeloUsuario = new ViewModelUsuario();
            return Ok(vistaModeloUsuario.ConvertirDesdeEntidad(user));
        }else
            return NotFound("Verifique los datos ingresados");
    }

    [HttpPost ("registrarse")]
    public IActionResult registrarUsuario(ViewModelRegistrarse registro){
        if(registro != null){
            
        }
        return Ok();
    }
}
