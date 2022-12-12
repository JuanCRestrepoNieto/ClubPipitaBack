namespace Data.Repositorio;

public class RepositorioPersona
{
   private readonly CLUBPIPITAContext context;
    public RepositorioPersona(CLUBPIPITAContext context)
    {
        this.context = context;
    }

    public void Actualizar(Persona persona){
        context.Personas.Update(persona);
    }
    public int ConfirmarCambios()
    {
        return context.SaveChanges();
    }
    public Persona Agregar(Persona persoan)
    {
        return context.Personas.Add(persoan).Entity;
    }
}
