using Data;
using Data.Repositorio;
using Microsoft.Extensions.Configuration;
using Model.View;

namespace Services;

public class ServicePersona
{
    private readonly RepositorioPersona repositorioPersona;
    private readonly IConfiguration _config;

    public ServicePersona(RepositorioPersona repositorioPersona, IConfiguration config)
    {
        this.repositorioPersona = repositorioPersona;
        this._config = config;
    }

    public bool ValidarPersona(ViewModelJugador persona)
    {
        if(persona.Id != null && persona.Nombre!=null && persona.Apellido != null && persona.Telefono != null)
            return true;
        else 
            return false;
    }

    public bool ActualizarDatos(ViewModelJugador persona)
    {
        if(ValidarPersona(persona))
        {
            Persona personaNewData = new Persona {
                Apellido = persona.Apellido,
                Nombre = persona.Nombre,
                Telefono = persona.Telefono,
                Id = persona.Id
            };
            int sw;
            repositorioPersona.Actualizar(personaNewData);
            sw = repositorioPersona.ConfirmarCambios();
            if(sw>0)
                return true;
            else 
                return false;
        }else
            return false;
    }

    public Persona AgregarPersona(ViewModelJugador jugador)
    {
        if(ValidarPersona(jugador))
        {
            Persona personaAdd = new Persona {
                Apellido = jugador.Apellido,
                Nombre = jugador.Nombre,
                Id = jugador.Id,
                Telefono = jugador.Telefono
            };
            Persona personaAgregada = repositorioPersona.Agregar(personaAdd);
            int cambios = repositorioPersona.ConfirmarCambios();
            if(cambios>0)
                return personaAgregada;
            else
                return null;
        }else
            return null;
    }
}
