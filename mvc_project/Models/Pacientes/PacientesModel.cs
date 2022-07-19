namespace mvc_project.Models.Pacientes
{
    public class PacientesModel
    {
        public string Id { get; set; }
        public string TipeDoc { get; set; }

        public string Dni { get; set; }
        
        public string Name { get; set; }

        public string LastNname { get; set; }

        public string Birth { get; set; }
        public string Sex { get; set; }

        public string MedicalSecurity { get; set; }
}
}