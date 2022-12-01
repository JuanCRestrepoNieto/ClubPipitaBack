using Data;
using Data.Repositorio;
using Microsoft.Extensions.Configuration;

namespace Services;

public class ServiceRol
{

    private readonly RepositorioRol repositorioRol;
    private readonly IConfiguration _config;

    public ServiceRol(RepositorioUsuario repositorioUsuario, IConfiguration config)
    {
        this.repositorioRol = repositorioRol;
        this._config = config;
    }

    public string ObtenerRol(string codigo){
        return repositorioRol.ObtenerEntidad(codigo).Descripcion;
    }

}
