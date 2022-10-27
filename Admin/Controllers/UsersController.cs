using Admin.Service;
using Database.Data;
using Design.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;

       
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserController
        [Route("/management/users")]
        public ActionResult Index()
        {
            var users = _context.Users;

            if (users is not null)
            {
                var userDto = users.Select(x => new UsersDto()
                {
                    Id = x.Id,
                    FirstName = x.UserName,
                    LastName = "",
                    Email = x.Email,
                    Phone = x.PhoneNumber
                });
                return View(userDto);
            }
            return NotFound();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
