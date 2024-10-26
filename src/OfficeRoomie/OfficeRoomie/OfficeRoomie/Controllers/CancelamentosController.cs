using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeRoomie.Database;

namespace OfficeRoomie.Controllers
{
    public class CancelamentosController : Controller
    {
        private readonly AppDbContext _context;

        public CancelamentosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        { 
            var dados = await _context.Cancelamentos.ToListAsync();

            return View(dados);
        }
    }   
}
