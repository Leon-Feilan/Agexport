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
    public class ColaboradorMainController : ControllerBase
    {
        private readonly MainContext _context;

        public ColaboradorMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/ColaboradorMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColaboradorDetail>>> GetColaborador()
        {
          if (_context.Colaborador == null)
          {
              return NotFound();
          }
            return await _context.Colaborador.ToListAsync();
        }

        // GET: api/ColaboradorMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ColaboradorDetail>> GetColaboradorDetail(int id)
        {
          if (_context.Colaborador == null)
          {
              return NotFound();
          }
            var colaboradorDetail = await _context.Colaborador.FindAsync(id);

            if (colaboradorDetail == null)
            {
                return NotFound();
            }

            return colaboradorDetail;
        }

        // PUT: api/ColaboradorMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColaboradorDetail(int id, ColaboradorDetail colaboradorDetail)
        {
            if (id != colaboradorDetail.CodColaborador)
            {
                return BadRequest();
            }

            _context.Entry(colaboradorDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColaboradorDetailExists(id))
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

        // POST: api/ColaboradorMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ColaboradorDetail>> PostColaboradorDetail(ColaboradorDetail colaboradorDetail)
        {
          if (_context.Colaborador == null)
          {
              return Problem("Entity set 'MainContext.Colaborador'  is null.");
          }
            _context.Colaborador.Add(colaboradorDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetColaboradorDetail", new { id = colaboradorDetail.CodColaborador }, colaboradorDetail);
        }

        // DELETE: api/ColaboradorMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColaboradorDetail(int id)
        {
            if (_context.Colaborador == null)
            {
                return NotFound();
            }
            var colaboradorDetail = await _context.Colaborador.FindAsync(id);
            if (colaboradorDetail == null)
            {
                return NotFound();
            }

            _context.Colaborador.Remove(colaboradorDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ColaboradorDetailExists(int id)
        {
            return (_context.Colaborador?.Any(e => e.CodColaborador == id)).GetValueOrDefault();
        }
    }
}
