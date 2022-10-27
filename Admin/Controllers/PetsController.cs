using Database.Data;
using Design.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class PetsController : Controller
    {
        private ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PetsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: PetsController
        [Route("/management/pets")]
        public ActionResult Index()
        {
            var pets = _context.pets;

            if (pets is not null)
            {
                var petsDto = pets.Select(x => new PetsDto()
                {
                    pet_Id = x.pet_Id,
                    pet_Name = x.pet_Name,
                    pet_Description = x.pet_Description,
                    pet_Lifespan = x.pet_Lifespan,
                    pet_Image1 = x.pet_Image1,
                    pet_Origin = x.pet_Origin,
                    pet_OrtherName = x.pet_OrtherName,
                    pet_Price = x.pet_Price,
                    pet_Weight = x.pet_Weight
                });

                return View(petsDto);
            }

            return NotFound();

           
        }

        // GET: PetsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetsController/Create
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

        // GET: PetsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetsController/Edit/5
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

        // GET: PetsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetsController/Delete/5
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
