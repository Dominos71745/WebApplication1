using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Wynik", dane);
            }
            else
            {
                return View(); // This will return the "Form" view with validation errors
            }
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
