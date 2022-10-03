using System;

namespace entity_library
{
    public class Profesional
    {
    public int IdProfesional { get; set; }

    public Calendario oIdCalendario { get; set; }

    public string TipoDni { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Especialidad { get; set; }

    public int Matricula { get; set; }
    
    }
}