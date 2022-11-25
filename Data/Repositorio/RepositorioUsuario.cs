using Microsoft.EntityFrameworkCore;

namespace Data.Repositorio;

public class RepositorioUsuario
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioUsuario(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public Usuario IniciarSesion(string usuario)
    {
        return context.Usuarios.Include(r => r.CodRolNavigation).FirstOrDefault(u => u.Correo == usuario);
    }
}
