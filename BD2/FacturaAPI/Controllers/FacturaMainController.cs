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
    public class FacturaMainController : ControllerBase
    {
        private readonly MainContext _context;

        public FacturaMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/FacturaMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaDetail>>> GetFactura()
        {
          if (_context.Factura == null)
          {
              return NotFound();
          }
            return await _context.Factura.ToListAsync();
        }

        // GET: api/FacturaMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacturaDetail>> GetFacturaDetail(int id)
        {
          if (_context.Factura == null)
          {
              return NotFound();
          }
            var facturaDetail = await _context.Factura.FindAsync(id);

            if (facturaDetail == null)
            {
                return NotFound();
            }

            return facturaDetail;
        }

        // PUT: api/FacturaMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturaDetail(int id, FacturaDetail facturaDetail)
        {
            if (id != facturaDetail.CodFactura)
            {
                return BadRequest();
            }

            _context.Entry(facturaDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaDetailExists(id))
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

        // POST: api/FacturaMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FacturaDetail>> PostFacturaDetail(FacturaDetail facturaDetail)
        {
          if (_context.Factura == null)
          {
              return Problem("Entity set 'MainContext.Factura'  is null.");
          }
            _context.Factura.Add(facturaDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturaDetail", new { id = facturaDetail.CodFactura }, facturaDetail);
        }

        // DELETE: api/FacturaMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacturaDetail(int id)
        {
            if (_context.Factura == null)
            {
                return NotFound();
            }
            var facturaDetail = await _context.Factura.FindAsync(id);
            if (facturaDetail == null)
            {
                return NotFound();
            }

            _context.Factura.Remove(facturaDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacturaDetailExists(int id)
        {
            return (_context.Factura?.Any(e => e.CodFactura == id)).GetValueOrDefault();
        }
    }
}
