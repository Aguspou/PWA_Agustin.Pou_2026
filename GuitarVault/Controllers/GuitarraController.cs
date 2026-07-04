using Microsoft.AspNetCore.Mvc;
using GuitarVault.BD;
using GuitarVault.Models;

namespace GuitarVault.Controllers
{
    public class GuitarraController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GuitarraController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int pagina = 1)
        {
            int porPagina = 5;
            int totalGuitarras = _dbContext.Guitarras.Count();
            int totalPaginas = (int)Math.Ceiling(totalGuitarras / (double)porPagina);
            if (totalPaginas < 1) totalPaginas = 1;

            List<GuitarraModel> lista = _dbContext.Guitarras
                .OrderBy(g => g.Nombre)
                .Skip((pagina - 1) * porPagina)
                .Take(porPagina)
                .ToList();

            ViewBag.PaginaActual = pagina;
            ViewBag.TotalPaginas = totalPaginas;
            return View(lista);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(GuitarraModel guitarra)
        {
            if (!ModelState.IsValid) return View(guitarra);
            _dbContext.Guitarras.Add(guitarra);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            GuitarraModel guitarra = _dbContext.Guitarras.Find(id);
            if (guitarra == null) return NotFound();
            return View(guitarra);
        }

        [HttpPost]
        public IActionResult Detalle(GuitarraModel guitarra)
        {
            if (!ModelState.IsValid) return View(guitarra);
            _dbContext.Guitarras.Update(guitarra);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            GuitarraModel guitarra = _dbContext.Guitarras.Find(id);
            if (guitarra == null) return NotFound();
            return View(guitarra);
        }

        [HttpPost]
        public IActionResult Eliminar(GuitarraModel guitarra)
        {
            GuitarraModel g = _dbContext.Guitarras.Find(guitarra.Id);
            if (g == null) return NotFound();
            _dbContext.Guitarras.Remove(g);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}