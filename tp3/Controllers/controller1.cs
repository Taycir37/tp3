using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tp3.Controllers
{
    public class controller1 : Controller
    {
        // GET: controller1
        public ActionResult Index()
        {
            return View();
        }

        // GET: controller1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: controller1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: controller1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: controller1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: controller1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: controller1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: controller1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
