using Microsoft.AspNetCore.Mvc;
using tp3.Models;
using tp3.Models.repositories;

namespace tp3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly repository<Employe> EmployeeRepository;

        public EmployeeController(repository<Employe> empRepository)
        {
            EmployeeRepository = empRepository;
        }

        public ActionResult Index(string search)
        {
            var list = string.IsNullOrWhiteSpace(search)
                ? EmployeeRepository.GetAll()
                : EmployeeRepository.Search(search);
            return View(list);
        }

        public ActionResult Details(int id)
        {
            var emp = EmployeeRepository.FindById(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employe e)
        {
            if (!ModelState.IsValid) return View(e);
            EmployeeRepository.Add(e);
            return RedirectToAction(nameof(Index));
        }

        // CORRECTION: GET pour afficher le formulaire
        public ActionResult Edit(int id)
        {
            var emp = EmployeeRepository.FindById(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        // POST pour sauvegarder les modifications
        [HttpPost]
        public ActionResult Edit(int id, Employe newEmployee)
        {
            if (!ModelState.IsValid) return View(newEmployee);
            EmployeeRepository.Update(id, newEmployee);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var emp = EmployeeRepository.FindById(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}