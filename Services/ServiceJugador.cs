using Data;
using Data.Repositorio;
using Model.View;

namespace Services;

public class ServiceJugador
{
    private readonly RepositorioJugador repositorioJugador;
    public ServiceJugador(RepositorioJugador repositorioJugador)
    {
        this.repositorioJugador = repositorioJugador;
    }

    public bool ActualizarJugador(ViewModelJugador jugador){
        if(jugador != null){
            Jugador jugadorNuevosDatos = new Jugador {
                Codequipo = jugador.CodEquipo,
                Numdorsal = jugador.Dorsal,
                Id = jugador.Id
            };
            
            repositorioJugador.Actualizar(jugadorNuevosDatos);

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
