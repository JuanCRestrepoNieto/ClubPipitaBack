using Data;

namespace Model.View;

public class ViewModelEquipo
{
    public string Codigo { get; set; } = null!;
    public string? Nombre { get; set; }

    public virtual ICollection<Jugador> Jugadors { get; set; }
    public virtual ICollection<Partidojugado> Partidojugados { get; set; }

    public virtual ICollection<Patrocinador> Idpatrocinadors { get; set; }

    public ViewModelEquipo RetornarVistaEquipo(Equipo equipo)
    {
        if(equipo != null)
        {
            Codigo = equipo.Codigo;
            Idpatrocinadors = equipo.Idpatrocinadors;
            Jugadors = equipo.Jugadors;
            Nombre = equipo.Nombre;
            Partidojugados = equipo.Partidojugados;
            return this;
        }else{
            return null;
        }
    }
}
