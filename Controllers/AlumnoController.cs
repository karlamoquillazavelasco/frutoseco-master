using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;

namespace demomvc.Controllers
{
    public class AlumnoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public AlumnoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Alumno objAlumno)
        {
            _context.Add(objAlumno);
            _context.SaveChanges();
            ViewData["Message"] = "El Alumno ya esta registrado";
            return View("Index");
        }

    }
}