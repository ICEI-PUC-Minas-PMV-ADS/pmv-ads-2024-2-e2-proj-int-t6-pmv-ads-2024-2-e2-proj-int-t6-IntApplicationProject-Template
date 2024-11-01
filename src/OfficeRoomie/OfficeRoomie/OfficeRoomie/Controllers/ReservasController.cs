using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeRoomie.Database;
using OfficeRoomie.Helpers;
using OfficeRoomie.Models;
using OfficeRoomie.Models.ViewModels;

namespace OfficeRoomie.Controllers
{
    public class ReservasController : Controller
    {
        private readonly AppDbContext _context;

        public ReservasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            var reservas = _context.Reserva
                .OrderByDescending(a => a.id)
                .Include(r => r.cliente)
                .Include(r => r.sala);
            var reservasPaginados = await ModelPaginado<Reserva>.CreateAsync(reservas, pageNumber ?? 1, 5);
            
            return View(reservasPaginados);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.sala)
                .FirstOrDefaultAsync(m => m.id == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        async public Task<IActionResult> Create()
        {
            var salas = await _context.Salas.ToListAsync();
            var clientes = await _context.Clientes.ToListAsync();

            var viewModel = new ReservaCreate
            {
                reserva = new Reserva(),
                salas = salas,
                clientes = clientes
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ReservaCreate dto)
        {
            if (ModelState.IsValid)
            {
                var reserva = new Reserva
                {
                    hora_inicio = dto.reserva.hora_inicio,
                    hora_fim = dto.reserva.hora_fim,
                    data_reserva = dto.reserva.data_reserva,
                    status = dto.reserva.status,
                    cliente_id = dto.reserva.cliente_id,
                    sala_id = dto.reserva.sala_id,
                    protocolo = ProtocoloHelper.GerarProtocolo(),
                };

                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dto);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }

            var salas = await _context.Salas.ToListAsync();
            var clientes = await _context.Clientes.ToListAsync();

            var viewModel = new ReservaCreate
            {
                reserva = reserva,
                salas = salas,
                clientes = clientes
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [FromForm] ReservaCreate dto)
        {
            if (id != dto.reserva.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var reserva = new Reserva
                {
                    hora_inicio = dto.reserva.hora_inicio,
                    hora_fim = dto.reserva.hora_fim,
                    data_reserva = dto.reserva.data_reserva,
                    status = dto.reserva.status,
                    cliente_id = dto.reserva.cliente_id,
                    sala_id = dto.reserva.sala_id,
                };

                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dto);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.sala)
                .FirstOrDefaultAsync(m => m.id == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva != null)
            {
                _context.Reserva.Remove(reserva);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reserva.Any(e => e.id == id);
        }
    }
}
