using System;

namespace entity_library
{
    public class Turno
    {
    public int IdTurno { get; set; }

    public string Usuario { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Especialidad { get; set; }

    public string PracticaPorTurno { get; set; }

    public string Profesional { get; set; }

    public int FechaTurno { get; set; }

    public int HoraTurno { get; set; }
    }
}