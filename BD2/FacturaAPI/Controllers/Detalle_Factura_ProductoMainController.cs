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
    public class Detalle_Factura_ProductoMainController : ControllerBase
    {
        private readonly MainContext _context;

        public Detalle_Factura_ProductoMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/Detalle_Factura_ProductoMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_Factura_ProductoDetail>>> Getdetalle_Factura_Producto()
        {
          if (_context.detalle_Factura_Producto == null)
          {
              return NotFound();
          }
            return await _context.detalle_Factura_Producto.ToListAsync();
        }

        // GET: api/Detalle_Factura_ProductoMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_Factura_ProductoDetail>> GetDetalle_Factura_ProductoDetail(int id)
        {
          if (_context.detalle_Factura_Producto == null)
          {
              return NotFound();
          }
            var detalle_Factura_ProductoDetail = await _context.detalle_Factura_Producto.FindAsync(id);

            if (detalle_Factura_ProductoDetail == null)
            {
                return NotFound();
            }

            return detalle_Factura_ProductoDetail;
        }

        // PUT: api/Detalle_Factura_ProductoMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle_Factura_ProductoDetail(int id, Detalle_Factura_ProductoDetail detalle_Factura_ProductoDetail)
        {
            if (id != detalle_Factura_ProductoDetail.OmitId)
            {
                return BadRequest();
            }

            _context.Entry(detalle_Factura_ProductoDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_Factura_ProductoDetailExists(id))
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

        // POST: api/Detalle_Factura_ProductoMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_Factura_ProductoDetail>> PostDetalle_Factura_ProductoDetail(Detalle_Factura_ProductoDetail detalle_Factura_ProductoDetail)
        {
          if (_context.detalle_Factura_Producto == null)
          {
              return Problem("Entity set 'MainContext.detalle_Factura_Producto'  is null.");
          }
            _context.detalle_Factura_Producto.Add(detalle_Factura_ProductoDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalle_Factura_ProductoDetail", new { id = detalle_Factura_ProductoDetail.OmitId }, detalle_Factura_ProductoDetail);
        }

        // DELETE: api/Detalle_Factura_ProductoMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle_Factura_ProductoDetail(int id)
        {
            if (_context.detalle_Factura_Producto == null)
            {
                return NotFound();
            }
            var detalle_Factura_ProductoDetail = await _context.detalle_Factura_Producto.FindAsync(id);
            if (detalle_Factura_ProductoDetail == null)
            {
                return NotFound();
            }

            _context.detalle_Factura_Producto.Remove(detalle_Factura_ProductoDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalle_Factura_ProductoDetailExists(int id)
        {
            return (_context.detalle_Factura_Producto?.Any(e => e.OmitId == id)).GetValueOrDefault();
        }
    }
}
