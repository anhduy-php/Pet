using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class PuppyController : Controller
    {
        // GET: PuppyController
        [Route("/puppy")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: PuppyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PuppyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PuppyController/Create
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

        // GET: PuppyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PuppyController/Edit/5
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

        // GET: PuppyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PuppyController/Delete/5
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
