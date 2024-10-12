using Microsoft.AspNetCore.Mvc;

namespace StockUp.Controllers
{
    public class FornecedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
