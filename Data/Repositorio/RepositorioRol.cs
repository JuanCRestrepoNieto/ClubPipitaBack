namespace Data.Repositorio;

public class RepositorioRol
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioRol(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public Rol ObtenerEntidad(string codigo){
        return context.Rols.FirstOrDefault(r => r.Codigo == codigo);
    }
}
