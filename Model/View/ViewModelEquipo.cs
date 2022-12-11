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
            this.Codigo = equipo.Codigo;
            this.Idpatrocinadors = equipo.Idpatrocinadors;
            this.Jugadors = equipo.Jugadors;
            this.Nombre = equipo.Nombre;
            this.Partidojugados = equipo.Partidojugados;
            return this;
        }else{
            return null;
        }
    }
}
