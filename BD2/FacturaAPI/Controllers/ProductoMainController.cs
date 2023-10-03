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
    public class ProductoMainController : ControllerBase
    {
        private readonly MainContext _context;

        public ProductoMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/ProductoMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoDetail>>> GetProducto()
        {
          if (_context.Producto == null)
          {
              return NotFound();
          }
            return await _context.Producto.ToListAsync();
        }

        // GET: api/ProductoMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoDetail>> GetProductoDetail(int id)
        {
          if (_context.Producto == null)
          {
              return NotFound();
          }
            var productoDetail = await _context.Producto.FindAsync(id);

            if (productoDetail == null)
            {
                return NotFound();
            }

            return productoDetail;
        }

        // PUT: api/ProductoMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductoDetail(int id, ProductoDetail productoDetail)
        {
            if (id != productoDetail.CodProducto)
            {
                return BadRequest();
            }

            _context.Entry(productoDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoDetailExists(id))
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

        // POST: api/ProductoMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductoDetail>> PostProductoDetail(ProductoDetail productoDetail)
        {
          if (_context.Producto == null)
          {
              return Problem("Entity set 'MainContext.Producto'  is null.");
          }
            _context.Producto.Add(productoDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductoDetail", new { id = productoDetail.CodProducto }, productoDetail);
        }

        // DELETE: api/ProductoMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductoDetail(int id)
        {
            if (_context.Producto == null)
            {
                return NotFound();
            }
            var productoDetail = await _context.Producto.FindAsync(id);
            if (productoDetail == null)
            {
                return NotFound();
            }

            _context.Producto.Remove(productoDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductoDetailExists(int id)
        {
            return (_context.Producto?.Any(e => e.CodProducto == id)).GetValueOrDefault();
        }
    }
}
