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
    public class GeneroMainController : ControllerBase
    {
        private readonly MainContext _context;

        public GeneroMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/GeneroMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneroDetail>>> GetGenero()
        {
          if (_context.Genero == null)
          {
              return NotFound();
          }
            return await _context.Genero.ToListAsync();
        }

        // GET: api/GeneroMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneroDetail>> GetGeneroDetail(int id)
        {
          if (_context.Genero == null)
          {
              return NotFound();
          }
            var generoDetail = await _context.Genero.FindAsync(id);

            if (generoDetail == null)
            {
                return NotFound();
            }

            return generoDetail;
        }

        // PUT: api/GeneroMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneroDetail(int id, GeneroDetail generoDetail)
        {
            if (id != generoDetail.CodGenero)
            {
                return BadRequest();
            }

            _context.Entry(generoDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroDetailExists(id))
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

        // POST: api/GeneroMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GeneroDetail>> PostGeneroDetail(GeneroDetail generoDetail)
        {
          if (_context.Genero == null)
          {
              return Problem("Entity set 'MainContext.Genero'  is null.");
          }
            _context.Genero.Add(generoDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneroDetail", new { id = generoDetail.CodGenero }, generoDetail);
        }

        // DELETE: api/GeneroMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeneroDetail(int id)
        {
            if (_context.Genero == null)
            {
                return NotFound();
            }
            var generoDetail = await _context.Genero.FindAsync(id);
            if (generoDetail == null)
            {
                return NotFound();
            }

            _context.Genero.Remove(generoDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeneroDetailExists(int id)
        {
            return (_context.Genero?.Any(e => e.CodGenero == id)).GetValueOrDefault();
        }
    }
}
