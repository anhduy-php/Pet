using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class PetDetailController : Controller
    {
        // GET: PetDetailController
        [Route("/petdetail")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: PetDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetDetailController/Create
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

        // GET: PetDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetDetailController/Edit/5
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

        // GET: PetDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetDetailController/Delete/5
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
