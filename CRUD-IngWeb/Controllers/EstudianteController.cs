using CRUD_IngWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_IngWeb.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        [HttpGet]
        public ActionResult Index()
        {
            var estudiantes = EstudianteRepository.GetEstudiantes();
            return View(estudiantes);
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            var estudiante = EstudianteRepository.GetEstudianteId(id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                EstudianteRepository.AgregarEstudiante(estudiante);
                return RedirectToAction("Index");
            }
            return View(estudiante);
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            var estudiante = EstudianteRepository.GetEstudianteId(id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                EstudianteRepository.ActualizarEstudiante(estudiante);
                return RedirectToAction("Index");
            }
            return View(estudiante);
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            var estudiante = EstudianteRepository.GetEstudianteId(id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        // POST: Estudiante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstudianteRepository.EliminarEstudiante(id);
            return RedirectToAction("Index");
        }
    }
}