namespace Data.Repositorio;

public class RepositorioPersona
{
    protected readonly CLUBPIPITAContext context;
    public RepositorioPersona(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public int Registrar(Persona persona){
        context.Personas.Add(persona);
        return context.SaveChanges();
    }
}
