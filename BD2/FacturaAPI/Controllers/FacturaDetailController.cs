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
    public class FacturaDetailController : ControllerBase
    {
        private readonly FacturaDetailContext _context;

        public FacturaDetailController(FacturaDetailContext context)
        {
            _context = context;
        }

        // GET: api/FacturaDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaDetail>>> GetFacturaDetail()
        {
          if (_context.FacturaDetail == null)
          {
              return NotFound();
          }
            return await _context.FacturaDetail.ToListAsync();
        }

        // GET: api/FacturaDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacturaDetail>> GetFacturaDetail(int id)
        {
          if (_context.FacturaDetail == null)
          {
              return NotFound();
          }
            var facturaDetail = await _context.FacturaDetail.FindAsync(id);

            if (facturaDetail == null)
            {
                return NotFound();
            }

            return facturaDetail;
        }

        // PUT: api/FacturaDetail/5
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

        // POST: api/FacturaDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FacturaDetail>> PostFacturaDetail(FacturaDetail facturaDetail)
        {
          if (_context.FacturaDetail == null)
          {
              return Problem("Entity set 'FacturaDetailContext.FacturaDetail'  is null.");
          }
            _context.FacturaDetail.Add(facturaDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturaDetail", new { id = facturaDetail.CodFactura }, facturaDetail);
        }

        // DELETE: api/FacturaDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacturaDetail(int id)
        {
            if (_context.FacturaDetail == null)
            {
                return NotFound();
            }
            var facturaDetail = await _context.FacturaDetail.FindAsync(id);
            if (facturaDetail == null)
            {
                return NotFound();
            }

            _context.FacturaDetail.Remove(facturaDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacturaDetailExists(int id)
        {
            return (_context.FacturaDetail?.Any(e => e.CodFactura == id)).GetValueOrDefault();
        }
    }
}
