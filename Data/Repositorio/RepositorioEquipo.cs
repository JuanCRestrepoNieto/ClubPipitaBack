using Microsoft.EntityFrameworkCore;

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
        return context.Equipos.Include(j => j.Jugadors).ThenInclude(j => j.IdNavigation).FirstOrDefault(e => e.Nombre == nombreEquipo);
    }

}