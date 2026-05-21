using GuitarVault.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuitarVault.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tipos()
        {
            return View();
        }

        public IActionResult Historia()
        {
            return View();
        }

        public IActionResult Curiosidades()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View(new ContactoModel());
        }

        [HttpPost]
        public IActionResult Contacto(ContactoModel model)
        {
            // Por ahora solo redirige.. en el futuro acá va la persistencia
            return RedirectToAction("Index");
        }
    }
}