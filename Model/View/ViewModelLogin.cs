using Data;

namespace Model.View;

public class ViewModelLogin
{
    public string Correo { get; set; } 
    public string? Contarsena { get; set; }
    public ViewModelLogin ConvertirDesdeEntidad(string usuario, string contrasena)
    {
        if (usuario != null && contrasena != null)
        {
            Correo = usuario;
            Contarsena = contrasena;
        }
        return this;
    }


}