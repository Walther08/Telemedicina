using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
    IEnumerable<Estudiante> GetAllEstudiantes();
    Estudiante AddEstudiante (Estudiante estudiante);
    Estudiante UpdateEstudiante (Estudiante estudiante);
    void DeleteEstudiante (int IdEstudiante);
    Estudiante GetEstudiante (int IdEstudiante);
    
    }
    
}