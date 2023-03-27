using Microsoft.AspNetCore.Mvc;
using WEBTest.Data;
using WEBTest.Models;

namespace WEBTest.Controllers
{
    public class MovimentController : Controller
    {
        private readonly Context _context;

        public MovimentController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Movimentações> moviments = _context.movimenta;
            return View(moviments);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movimentações m)
        {
            var mov = new Movimentações()
            {
                ConteinerId = m.ConteinerId,
                Tipo = m.Tipo,
                DataFinal = m.DataFinal,
                DataInitial = m.DataInitial,
            };

            _context.movimenta.Add(mov);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
