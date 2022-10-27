using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database.Data;
using Database.Entities;
using Design.Models.Dto;

namespace Admin.Controllers
{
    public class BillsController : Controller
    {
        private ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BillsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: BillsController
        [Route("/management/bills")]
        public ActionResult Index()
        {
            var bills = _context.bills;

            if (bills is not null)
            {
                var billsDto = bills.Select(x => new BillsDto()
                {
                    bill_Id = x.bill_Id,
                    bill_UserId = x.bill_UserId,
                    bill_UserName = "",
                    bill_StartDateTime = x.bill_StartDateTime,
                    bill_StatusPayment = x.bill_StatusPayment,
                    bill_StatusReviceOrder = x.bill_StatusReviceOrder,
                    bill_Cancel = x.bill_Cancel,
                    bill_Total = x.bill_Total
                });

                return View(billsDto);
            }

            return NotFound();
        }

        // GET: BillsController/Details/5
        [Route("/management/bills/details")]
        public ActionResult Details(string id)
        {
            var bills = _context.bills.FirstOrDefault(x => x.bill_Id == id);

            if (bills is not null)
            {
                var billsDto = new BillsDto()
                {
                    bill_Id = bills.bill_Id,
                    bill_UserId = bills.bill_UserId,
                    bill_UserName = "",
                    bill_StartDateTime = bills.bill_StartDateTime,
                    bill_StatusPayment = bills.bill_StatusPayment,
                    bill_StatusReviceOrder = bills.bill_StatusReviceOrder,
                    bill_Cancel = bills.bill_Cancel,
                    bill_Total = bills.bill_Total
                };

                return View(billsDto);
            }
            return NotFound();
        }

        // GET: BillsController/Edit/5
        [Route("/management/bills/edit")]
        public ActionResult Edit(string id)
        {
            var bills = _context.bills.FirstOrDefault(x => x.bill_Id == id);
            if (bills is not null)
            {
                var billsDto = new BillsDto()
                {
                    bill_Id = bills.bill_Id,
                    bill_UserId = bills.bill_UserId,
                    bill_UserName = "a",
                    bill_StartDateTime = bills.bill_StartDateTime,
                    bill_StatusPayment = bills.bill_StatusPayment,
                    bill_StatusReviceOrder = bills.bill_StatusReviceOrder,
                    bill_Cancel = bills.bill_Cancel,
                    bill_Total = bills.bill_Total
                };

                return View(billsDto);
            }
            return NotFound();
        }


        // POST: BillsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/management/bills/edit")]
        public async Task<ActionResult> Edit(BillsDto billsDto)
        {
            try
            {
                var bills = _context.bills.FirstOrDefault(x => x.bill_Id == billsDto.bill_Id);
                if (bills is not null)
                {
                    bills.bill_Id = billsDto.bill_Id;
                    bills.bill_UserId = billsDto.bill_UserId;
                    bills.bill_StartDateTime = billsDto.bill_StartDateTime;
                    bills.bill_StatusPayment = billsDto.bill_StatusPayment;
                    bills.bill_Cancel = billsDto.bill_Cancel;
                    bills.bill_Total = billsDto.bill_Total;
                    bills.bill_StatusReviceOrder = billsDto.bill_StatusReviceOrder;

                    var result = _context.bills.Update(bills);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BillsController/Delete/5
        [Route("/management/bills/delete")]
        public ActionResult Delete(string id)
        {
            var bills = _context.bills.FirstOrDefault(x => x.bill_Id == id);
            if (bills is not null)
            {
                var billsDto = new BillsDto()
                {
                    bill_Id = bills.bill_Id,
                    bill_UserId = bills.bill_UserId,
                    bill_UserName = "a",
                    bill_StartDateTime = bills.bill_StartDateTime,
                    bill_StatusPayment = bills.bill_StatusPayment,
                    bill_StatusReviceOrder = bills.bill_StatusReviceOrder,
                    bill_Cancel = bills.bill_Cancel,
                    bill_Total = bills.bill_Total
                };
                return View(billsDto);
            }
            return NotFound();
        }

        // POST: BillsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/management/bills/delete")]
        public async Task<ActionResult> Delete(BillsDto billsDto)
        {
            try
            {
                var bills = _context.bills.FirstOrDefault(x => x.bill_Id == billsDto.bill_Id);
                if (bills is not null)
                _context.bills.Remove(bills);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
