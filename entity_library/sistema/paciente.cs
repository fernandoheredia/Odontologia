using System;

namespace entity_library
{
    public class Paciente
    {
    public int IdPaciente { get; set; }

    public Turno oIdTurno { get; set; }

    public Foto_de_paciente oIdFoto { get; set; }

    public string Tipo_Dni { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public int Nacimiento { get; set; }

    public string Sexo { get; set; }

    public string ObraSocial { get; set; }

    public int Telefono { get; set; }

    }
}