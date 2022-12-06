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

    public void Agregar(Jugador jugador)
    {
        context.Jugadors.Add(jugador);
    }

    public int ConfirmarCambios()
    {
        return context.SaveChanges();
    }
}
