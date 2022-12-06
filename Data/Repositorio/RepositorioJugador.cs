namespace Data.Repositorio;

public class RepositorioJugador
{
    private readonly CLUBPIPITAContext context;
    public RepositorioJugador(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public int Actualizar(Jugador jugador){
        context.Jugadors.Update(jugador);
        return context.SaveChanges();
    }
}
