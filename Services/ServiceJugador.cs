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

    public Jugador AgregarJugador(ViewModelJugador jugador)
    {
        if(jugador != null)
        {
            Jugador jugadorAdd = new Jugador {
                Codequipo = jugador.CodEquipo,
                Id = jugador.Id,
                Numdorsal = jugador.Dorsal
            };
            Jugador jugadorAgregado = repositorioJugador.Agregar(jugadorAdd);
            int cambios = repositorioJugador.ConfirmarCambios();
            if(cambios>0)
                return jugadorAgregado;
            else
                return null;
        }else{
            return null;
        }
    }

    public int Eliminarjugador(string id)
    {
        if(id != null)
        {
            Jugador jugador = new Jugador {
                Id = id
            };
            Jugador jugadorEliminado = repositorioJugador.Eliminar(jugador);
            if(jugadorEliminado!=null)
            {
                int sw = repositorioJugador.ConfirmarCambios();
                if(sw>0)
                    return sw;
                else
                    return 0;
            }
            else
                return -1;

        }else
            return -2;
    }
}
