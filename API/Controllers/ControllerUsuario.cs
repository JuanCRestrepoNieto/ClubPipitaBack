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
    protected readonly ServiceRol serviceRol;
    public ControllerUsuario(ServiceUsuario servicioUsuario, ServiceRol serviceRol)
    {
        this.serviceUsuario = servicioUsuario;
        this.serviceRol = serviceRol;
    }

    [HttpPost ("iniciarSesion")]
    public IActionResult obtenerUsuario(ViewModelLogin usuario){
        Usuario user = serviceUsuario.ValidarLogin(usuario.Correo, usuario.Contarsena); 
        if(user != null)
        {
            string rol = serviceRol.ObtenerRol(user.CodRol);
            ViewModelUsuario vistaModeloUsuario = new ViewModelUsuario();
            return Ok(vistaModeloUsuario.ConvertirDesdeEntidad(user, rol));
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
