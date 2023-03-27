using Microsoft.AspNetCore.Mvc;
using WEBTest.Data;

namespace WEBTest.Controllers
{
    public class SearchController : Controller
    {
        private readonly Context _context;

        public SearchController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string searching)
        {
            return View(_context.conteiners.Where(x => x.Cliente.StartsWith(searching)||searching == null).ToList());
        }

        public IActionResult SearchMovi(string searching)
        {
            return View(_context.movimenta.Where(x => x.ConteinerId.ToString().StartsWith(searching) || searching == null));
        }
    }
}
