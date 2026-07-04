using GuitarVault.BD;
using GuitarVault.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuitarVault.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
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
            if (!ModelState.IsValid) return View(model);
            model.Fecha = DateTime.Now;
            _dbContext.Contactos.Add(model);
            _dbContext.SaveChanges();
            ViewBag.Enviado = true;
            return View(new ContactoModel());
        }


    }
}