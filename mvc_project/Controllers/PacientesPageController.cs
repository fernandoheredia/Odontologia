using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;
using mvc_project.Models.ComponentUse;
using mvc_project.Models.Pacientes;

namespace mvc_project.Controllers
{
    public class PacientesController : Controller
    {
        private readonly ILogger<PacientesController> _logger;

        public PacientesController(ILogger<PacientesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePaciente()
        {
        PacientesModel pacienteslModel = new PacientesModel
         
         {
            Id="",
            TipeDoc="",
            Dni="",
            Name="",
            LastNname="",
            Birth="",
            Sex="",
            MedicalSecurity="",
         };
        
            return View("~/Views/PacientesPage/Index.cshtml", pacienteslModel);
        }
    }
}