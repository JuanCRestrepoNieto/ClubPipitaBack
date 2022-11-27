namespace Data.Repositorio;

public class RepositorioPersona
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioPersona(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public int RegistrarPersona(Persona persona){
        context.Personas.Add(persona);
        return context.SaveChanges();
    }
}
