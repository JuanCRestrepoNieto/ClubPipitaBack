using Data;

namespace Model.View;

public class ViewModelUsuario
{
    public string Correo { get; set; } = null!;
    public string? Contarsena { get; set; }
    public string? Codrol { get; set; }
    public string DescripcionRol {get; set;}
    public Rol rolUsuario {get; set;}
    public virtual ICollection<Persona> Personas { get; set; }
    public ViewModelUsuario ConvertirDesdeEntidad(Usuario usuario, string rol)
    {
        if (usuario != null)
        {
            Correo = usuario.Correo;
            Contarsena = usuario.Contarsena;
            Codrol = usuario.CodRol;
            DescripcionRol = rol;
        }
        return this;
    }

}
