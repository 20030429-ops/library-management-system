using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BorrowController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(object borrow)
        {
            ViewBag.Message = "Borrowing Transaction Completed Successfully";

            return View();
        }
    }
}