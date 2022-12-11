using Data;

namespace Model.View;

public class ViewModelEquipo
{
    public string Codigo { get; set; } = null!;
    public string? Nombre { get; set; }

    public virtual List<Jugador> Jugadors { get; set; }
    public virtual List<Partidojugado> Partidojugados { get; set; }

    public virtual List<Patrocinador> Idpatrocinadors { get; set; }

    public ViewModelEquipo RetornarVistaEquipo(Equipo equipo)
    {
        if(equipo != null)
        {
            this.Codigo = equipo.Codigo;
            this.Jugadors = equipo.Jugadors.ToList();
            this.Nombre = equipo.Nombre;
            return this;
        }else{
            return null;
        }
    }
}
