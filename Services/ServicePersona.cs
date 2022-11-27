using Data;
using Data.Repositorio;
using Microsoft.Extensions.Configuration;

namespace Services;

public class ServicePersona
{
    private readonly RepositorioUsuario repositorioUsuario;
    private readonly IConfiguration _config;

    public ServicePersona(RepositorioUsuario repositorioUsuario, IConfiguration config)
    {
        this.repositorioUsuario = repositorioUsuario;
        this._config = config;
    }

    public bool ValidarPersona(Persona persona){
        if(persona.Id != null && persona.Nombre!=null && persona.Apellido != null && persona.Telefono != null)
            return true;
        else 
            return false;
    }
}
