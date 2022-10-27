using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database.Data;
using Design.Models.Dto;

namespace Admin.Controllers
{
    public class ContactsController : Controller
    {
        private ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ContactsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: ContactsController
        [Route("/management/contacts")]
        public ActionResult Index()
        {
            var userContacts = _context.userContact;

            if (userContacts is not null)
            {
                var userContactsDto = userContacts.Select(x => new ContactsDto()
                {
                    uc_Id = x.uc_Id,
                    uc_UserCreate = x.uc_UserCreate,
                    uc_Content = x.uc_Content,
                    uc_Email = x.uc_Email,
                    uc_IsDelete = x.uc_IsDelete,
                    uc_Name = x.uc_Name,
                    uc_Phone = x.uc_Phone
                });

                return View(userContactsDto);
            }

            return NotFound();
        }

        // GET: ContactsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactsController/Create
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

        // GET: ContactsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactsController/Edit/5
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

        // GET: ContactsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactsController/Delete/5
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
