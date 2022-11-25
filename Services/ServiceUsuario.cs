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

    public Usuario ValidarUsuario(Usuario usuario)
    {
        if(usuario.Correo != null && usuario.Contarsena != null){
            Usuario user = repositorioUsuario.IniciarSesion(usuario.Correo);
            if(user != null){
                if(user.Contarsena == usuario.Contarsena)
                {
                    return new Usuario{
                        Correo = user.Correo,
                        Contarsena = user.Contarsena,
                        CodRolNavigation = user.CodRolNavigation
                    };
                }else
                    return null;
            }else
                return null;
            
        }else
        return null;
    }
}
