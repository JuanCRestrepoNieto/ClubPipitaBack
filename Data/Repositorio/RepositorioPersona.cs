namespace Data.Repositorio;

public class RepositorioPersona
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioPersona(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public void RegistrarPersona(Persona persona){
        context.Personas.Add(persona);
        context.SaveChanges();
    }
}
