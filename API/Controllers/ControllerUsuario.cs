using Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerUsuario : ControllerBase
{
    [HttpGet ("iniciarSesion{usuario}")]
    public IActionResult obtenerUsuario(Usuario usuario){
        
        return NotFound("kk");
    }
}
