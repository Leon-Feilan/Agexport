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
    public class ConsumidorDetailController : ControllerBase
    {
        private readonly ConsumidorDetailContext _context;

        public ConsumidorDetailController(ConsumidorDetailContext context)
        {
            _context = context;
        }

        // GET: api/ConsumidorDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsumidorDetail>>> GetconsumidorDetails()
        {
          if (_context.consumidorDetails == null)
          {
              return NotFound();
          }
            return await _context.consumidorDetails.ToListAsync();
        }

        // GET: api/ConsumidorDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsumidorDetail>> GetConsumidorDetail(int id)
        {
          if (_context.consumidorDetails == null)
          {
              return NotFound();
          }
            var consumidorDetail = await _context.consumidorDetails.FindAsync(id);

            if (consumidorDetail == null)
            {
                return NotFound();
            }

            return consumidorDetail;
        }

        // PUT: api/ConsumidorDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumidorDetail(int id, ConsumidorDetail consumidorDetail)
        {
            if (id != consumidorDetail.Nit)
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

        // POST: api/ConsumidorDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConsumidorDetail>> PostConsumidorDetail(ConsumidorDetail consumidorDetail)
        {
          if (_context.consumidorDetails == null)
          {
              return Problem("Entity set 'ConsumidorDetailContext.consumidorDetails'  is null.");
          }
            _context.consumidorDetails.Add(consumidorDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsumidorDetail", new { id = consumidorDetail.Nit }, consumidorDetail);
        }

        // DELETE: api/ConsumidorDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsumidorDetail(int id)
        {
            if (_context.consumidorDetails == null)
            {
                return NotFound();
            }
            var consumidorDetail = await _context.consumidorDetails.FindAsync(id);
            if (consumidorDetail == null)
            {
                return NotFound();
            }

            _context.consumidorDetails.Remove(consumidorDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsumidorDetailExists(int id)
        {
            return (_context.consumidorDetails?.Any(e => e.Nit == id)).GetValueOrDefault();
        }
    }
}
