using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Colaborador.Models;

namespace Colab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoColaboradorMainController : ControllerBase
    {
        private readonly MainContext _context;

        public TipoColaboradorMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/TipoColaboradorMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoColaborador>>> GetTipoColaborador()
        {
          if (_context.TipoColaborador == null)
          {
              return NotFound();
          }
            return await _context.TipoColaborador.ToListAsync();
        }

        // GET: api/TipoColaboradorMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoColaborador>> GetTipoColaborador(int id)
        {
          if (_context.TipoColaborador == null)
          {
              return NotFound();
          }
            var tipoColaborador = await _context.TipoColaborador.FindAsync(id);

            if (tipoColaborador == null)
            {
                return NotFound();
            }

            return tipoColaborador;
        }

        // PUT: api/TipoColaboradorMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoColaborador(int id, TipoColaborador tipoColaborador)
        {
            if (id != tipoColaborador.CodTipoColaborador)
            {
                return BadRequest();
            }

            _context.Entry(tipoColaborador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoColaboradorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TipoColaboradorMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoColaborador>> PostTipoColaborador(TipoColaborador tipoColaborador)
        {
          if (_context.TipoColaborador == null)
          {
              return Problem("Entity set 'MainContext.TipoColaborador'  is null.");
          }
            _context.TipoColaborador.Add(tipoColaborador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoColaborador", new { id = tipoColaborador.CodTipoColaborador }, tipoColaborador);
        }

        // DELETE: api/TipoColaboradorMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoColaborador(int id)
        {
            if (_context.TipoColaborador == null)
            {
                return NotFound();
            }
            var tipoColaborador = await _context.TipoColaborador.FindAsync(id);
            if (tipoColaborador == null)
            {
                return NotFound();
            }

            _context.TipoColaborador.Remove(tipoColaborador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoColaboradorExists(int id)
        {
            return (_context.TipoColaborador?.Any(e => e.CodTipoColaborador == id)).GetValueOrDefault();
        }
    }
}
