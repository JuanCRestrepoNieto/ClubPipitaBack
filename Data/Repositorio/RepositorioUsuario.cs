using Microsoft.EntityFrameworkCore;

namespace Data.Repositorio;

public class RepositorioUsuario
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioUsuario(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public Usuario Obtener(string usuario, string contrasena)
    {
        
        return context.Usuarios
                .FirstOrDefault(u => u.Correo == usuario && u.Contarsena == contrasena);
    }

    public int Registrar(Usuario user, Persona persona)
    {
            context.Usuarios.Add(user);
            return context.SaveChanges();
    }
}
