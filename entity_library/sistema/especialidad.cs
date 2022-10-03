using System;

namespace entity_library
{
    public class Especialidad
    {
    public int IdEspecialidad { get; set; }

    public Practica oIdPractica { get; set; }
    
    public string NombreEspecialidad { get; set; }

    }
}