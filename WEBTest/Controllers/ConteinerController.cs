using Microsoft.AspNetCore.Mvc;
using WEBTest.Data;
using WEBTest.Models;

namespace WEBTest.Controllers
{
    public class ConteinerController : Controller
    {
        private readonly Context _context;

        public ConteinerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Conteiner> cont = _context.conteiners;
            return View(cont);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Conteiner conteiner)
        {
            var cont = new Conteiner()
            {
                Cliente = conteiner.Cliente,
                Categoria = conteiner.Categoria,
                Tipo = conteiner.Tipo,
                Status = conteiner.Status,
            };

            _context.conteiners.Add(cont);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
