using Microsoft.EntityFrameworkCore;

namespace Data.Repositorio;

public class RepositorioUsuario
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioUsuario(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public Usuario IniciarSesion(string usuario, string contrasena)
    {
        return context.Usuarios
                .FirstOrDefault(u => u.Correo == usuario && u.Contarsena == contrasena);
    }
}
