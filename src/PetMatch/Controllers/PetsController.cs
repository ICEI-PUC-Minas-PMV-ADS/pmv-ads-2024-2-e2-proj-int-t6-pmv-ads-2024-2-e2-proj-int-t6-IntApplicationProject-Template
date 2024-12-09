using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetMatch.Models;

namespace PetMatch.Controllers
{
    public class PetsController(AppDBContext context) : Controller
    {
        private readonly AppDBContext _context = context;

        // GET: Pets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pets.ToListAsync());
        }

        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets.FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Idade,Raca,TipoPet,Sexo,Porte,Imagem")] Pet pet, IFormFile? imagemUpload)
        {
            if (ModelState.IsValid)
            {
                // Se uma imagem for carregada, converte para byte[]
                if (imagemUpload != null)
                {
                    using var memoryStream = new MemoryStream();
                    await imagemUpload.CopyToAsync(memoryStream);
                    pet.Imagem = memoryStream.ToArray();
                }

                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redireciona para a página inicial
            }
            return View(pet); // Se ModelState não for válido, retorna à view de criação
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            return View(pet);
        }

        // POST: Pets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Idade,Raca,TipoPet,Sexo,Porte,Imagem")] Pet pet, IFormFile? imagemUpload)
        {
            if (id != pet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Atualiza a imagem apenas se houver um novo upload
                    if (imagemUpload != null)
                    {
                        using var memoryStream = new MemoryStream();
                        await imagemUpload.CopyToAsync(memoryStream);
                        pet.Imagem = memoryStream.ToArray();
                    }

                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index)); // Redireciona para a página inicial
            }
            return View(pet); // Se ModelState não for válido, retorna à view de edição
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets.FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index)); // Redireciona para a página inicial
        }

        // Método auxiliar para verificar se o pet existe
        private bool PetExists(int id)
        {
            return _context.Pets.Any(e => e.Id == id);
        }
    }
}
