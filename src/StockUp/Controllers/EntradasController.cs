using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockUp.Models;

namespace StockUp.Controllers
{
    public class EntradasController : Controller
    {
        private readonly AppDbContext _context;
        public EntradasController(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Entradas.ToListAsync();

            return View(dados);
        }
    }
}
