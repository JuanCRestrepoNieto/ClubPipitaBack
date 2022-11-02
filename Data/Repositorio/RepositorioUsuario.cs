namespace Data.Repositorio;

public class RepositorioUsuario
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioUsuario(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public Usuario Obtener(string usuario)
    {
        return context.Usuarios.FirstOrDefault(u => u.Correo == usuario);
    }
}
