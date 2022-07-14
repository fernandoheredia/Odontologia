using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;
using mvc_project.Models.ComponentUse;
using mvc_project.Models.Profesional;

namespace mvc_project.Controllers
{
    public class ProfesionalController : Controller
    {
        private readonly ILogger<ProfesionalController> _logger;

        public ProfesionalController(ILogger<ProfesionalController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProfesional()
        {
        ProfesionalModel profesionalModel = new ProfesionalModel
         
         {
            Id="",
            TipeDoc="",
            Dni="",
            Name="",
            LastNname="",
            Specialty="",
            Tuition="",
         };
        
            return View("~/Views/ProfesionalPage/Index.cshtml", profesionalModel);
        }
    }
}