using Data;

namespace Model.View;

public class ViewModelUsuario
{
    public string Correo { get; set; } = null!;
    public string? Contarsena { get; set; }
    public string? Codrol { get; set; }
    public virtual Rol? CodrolNavigation { get; set; }
    public virtual ICollection<Persona> Personas { get; set; }
    public ViewModelUsuario ConvertirDesdeEntidad(Usuario usuario)
    {
        if (usuario != null)
        {
            Correo = usuario.Correo;
            Contarsena = usuario.Contarsena;
            CodrolNavigation = usuario.CodRolNavigation;
        }
        return this;
    }

}
