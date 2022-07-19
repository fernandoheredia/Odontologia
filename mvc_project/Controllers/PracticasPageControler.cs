using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;
using mvc_project.Models.ComponentUse;
using mvc_project.Models.Practicas;

namespace mvc_project.Controllers
{
    public class PracticasController : Controller
    {
        private readonly ILogger<PracticasController> _logger;

        public PracticasController(ILogger<PracticasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePracticas()
        {
        PracticasModel practicaslModel = new PracticasModel
         
         {
           
         };
        
            return View("~/Views/PracticasPage/Index.cshtml", practicaslModel);
        }
    }
}