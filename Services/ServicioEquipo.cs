using Data;
using Data.Repositorio;

namespace Services;

public class ServicioEquipo
{
    private readonly RepositorioEquipo repositorioEquipo;
    public ServicioEquipo(RepositorioEquipo repositorioEquipo)
    {
        this.repositorioEquipo = repositorioEquipo;
    }

    public Equipo ObtenerEquipo(string nombre)
    {
        if (nombre != null)
        {
            Equipo equipo = repositorioEquipo.Obtener(nombre);

            if (equipo != null)
            {
                if (equipo.Jugadors.Count > 0)
                {
                    return equipo;
                }
                else
                {
                    return new Equipo
                    {
                        Codigo = equipo.Codigo,
                        Idpatrocinadors = equipo.Idpatrocinadors,
                        Nombre = equipo.Nombre,
                        Partidojugados = equipo.Partidojugados
                    };
                }
            }else
                return null;
        }else
            return null;

    }
}
