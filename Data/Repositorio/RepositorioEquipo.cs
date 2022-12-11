namespace Data.Repositorio;

public class RepositorioEquipo
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioEquipo(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public Equipo Obtener(string nombreEquipo)
    {
        return context.Equipos.FirstOrDefault(e => e.Nombre == nombreEquipo);
    }

}