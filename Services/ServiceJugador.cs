using Data;
using Data.Repositorio;

namespace Services;

public class ServiceJugador
{
    private readonly RepositorioJugador repositorioJugador;
    public ServiceJugador(RepositorioJugador repositorioJugador)
    {
        this.repositorioJugador = repositorioJugador;
    }

    public bool ActualizarJugador(Jugador jugador){
        if(jugador != null){
            repositorioJugador.Actualizar(jugador);
            int actualizacion = repositorioJugador.ConfirmarCambios();
            if(actualizacion>0)
                return true;
            else
                return false;
        }else{
            return false;
        }
    }

    public bool AgregarJugador(Jugador jugador)
    {
        if(jugador != null)
        {
            repositorioJugador.Agregar(jugador);
            int actualizacion = repositorioJugador.ConfirmarCambios();
            if(actualizacion>0)
                return true;
            else
                return false;
        }else{
            return false;
        }
    }

}
