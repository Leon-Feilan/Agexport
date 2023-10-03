using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Factura.Models;

namespace Factura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumidorMainController : ControllerBase
    {
        private readonly MainContext _context;

        public ConsumidorMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/ConsumidorMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsumidorDetail>>> GetConsumidor()
        {
          if (_context.Consumidor == null)
          {
              return NotFound();
          }
            return await _context.Consumidor.ToListAsync();
        }

        // GET: api/ConsumidorMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsumidorDetail>> GetConsumidorDetail(int id)
        {
          if (_context.Consumidor == null)
          {
              return NotFound();
          }
            var consumidorDetail = await _context.Consumidor.FindAsync(id);

            if (consumidorDetail == null)
            {
                return NotFound();
            }

            return consumidorDetail;
        }

        // PUT: api/ConsumidorMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumidorDetail(int id, ConsumidorDetail consumidorDetail)
        {
            if (id != consumidorDetail.CodConsumidor)
            {
                return BadRequest();
            }

            _context.Entry(consumidorDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsumidorDetailExists(id))
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

        // POST: api/ConsumidorMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConsumidorDetail>> PostConsumidorDetail(ConsumidorDetail consumidorDetail)
        {
          if (_context.Consumidor == null)
          {
              return Problem("Entity set 'MainContext.Consumidor'  is null.");
          }
            _context.Consumidor.Add(consumidorDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsumidorDetail", new { id = consumidorDetail.CodConsumidor }, consumidorDetail);
        }

        // DELETE: api/ConsumidorMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsumidorDetail(int id)
        {
            if (_context.Consumidor == null)
            {
                return NotFound();
            }
            var consumidorDetail = await _context.Consumidor.FindAsync(id);
            if (consumidorDetail == null)
            {
                return NotFound();
            }

            _context.Consumidor.Remove(consumidorDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsumidorDetailExists(int id)
        {
            return (_context.Consumidor?.Any(e => e.CodConsumidor == id)).GetValueOrDefault();
        }
    }
}
