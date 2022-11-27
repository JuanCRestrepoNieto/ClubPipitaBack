using Data;
using Data.Repositorio;
using Microsoft.Extensions.Configuration;

namespace Services;

public class ServiceUsuario
{
    private readonly RepositorioUsuario repositorioUsuario;
    private readonly IConfiguration _config;

    public ServiceUsuario(RepositorioUsuario repositorioUsuario, IConfiguration config)
    {
        this.repositorioUsuario = repositorioUsuario;
        this._config = config;
    }

    public Usuario ValidarLogin(string usuario, string contrasena)
    {
        if (usuario != null && contrasena != null)
        {
            Usuario user = repositorioUsuario.IniciarSesion(usuario, contrasena);

            if (user != null)
            {
                return new Usuario
                {
                    Correo = user.Correo,
                    Contarsena = user.Contarsena,
                    CodRolNavigation = user.CodRolNavigation,
                };
            }
            else
                return null;

        }
        else
            return null;
    }

    

    public bool ValidarUsuario(Usuario user)
    {
        if (user.Correo != null && user.Contarsena != null){
            return true;
        }
        else{
            return false;
        }
    }

}
