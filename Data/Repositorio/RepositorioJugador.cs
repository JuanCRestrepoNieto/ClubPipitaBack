namespace Data.Repositorio;

public class RepositorioJugador
{
    private readonly CLUBPIPITAContext context;
    public RepositorioJugador(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public void Actualizar(Jugador jugador){
        context.Jugadors.Update(jugador);
    }

    public Jugador Agregar(Jugador jugador)
    {
        return context.Jugadors.Add(jugador).Entity;
    }

    public Jugador Eliminar(Jugador jugador)
    {
        return context.Jugadors.Remove(jugador).Entity;
    }

    public int ConfirmarCambios()
    {
        return context.SaveChanges();
    }
}
