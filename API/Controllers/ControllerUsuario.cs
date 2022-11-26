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
    public IActionResult obtenerUsuario(ViewModelUsuario usuario){
        Usuario user = serviceUsuario.ValidarUsuario(usuario.Correo, usuario.Contarsena); 
        if(user != null)
        {
            ViewModelUsuario vistaModeloUsuario = new ViewModelUsuario();
            return Ok(vistaModeloUsuario.ConvertirDesdeEntidad(user));
        }else
            return NotFound("Verifique los datos ingresados");
    }
}
