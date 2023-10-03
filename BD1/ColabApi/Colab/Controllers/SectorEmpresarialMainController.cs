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
    public class SectorEmpresarialMainController : ControllerBase
    {
        private readonly MainContext _context;

        public SectorEmpresarialMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/SectorEmpresarialMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SectorEmpresarialDetail>>> GetSectorEmpresarial()
        {
          if (_context.SectorEmpresarial == null)
          {
              return NotFound();
          }
            return await _context.SectorEmpresarial.ToListAsync();
        }

        // GET: api/SectorEmpresarialMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SectorEmpresarialDetail>> GetSectorEmpresarialDetail(int id)
        {
          if (_context.SectorEmpresarial == null)
          {
              return NotFound();
          }
            var sectorEmpresarialDetail = await _context.SectorEmpresarial.FindAsync(id);

            if (sectorEmpresarialDetail == null)
            {
                return NotFound();
            }

            return sectorEmpresarialDetail;
        }

        // PUT: api/SectorEmpresarialMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSectorEmpresarialDetail(int id, SectorEmpresarialDetail sectorEmpresarialDetail)
        {
            if (id != sectorEmpresarialDetail.CodSector)
            {
                return BadRequest();
            }

            _context.Entry(sectorEmpresarialDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectorEmpresarialDetailExists(id))
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

        // POST: api/SectorEmpresarialMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SectorEmpresarialDetail>> PostSectorEmpresarialDetail(SectorEmpresarialDetail sectorEmpresarialDetail)
        {
          if (_context.SectorEmpresarial == null)
          {
              return Problem("Entity set 'MainContext.SectorEmpresarial'  is null.");
          }
            _context.SectorEmpresarial.Add(sectorEmpresarialDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSectorEmpresarialDetail", new { id = sectorEmpresarialDetail.CodSector }, sectorEmpresarialDetail);
        }

        // DELETE: api/SectorEmpresarialMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSectorEmpresarialDetail(int id)
        {
            if (_context.SectorEmpresarial == null)
            {
                return NotFound();
            }
            var sectorEmpresarialDetail = await _context.SectorEmpresarial.FindAsync(id);
            if (sectorEmpresarialDetail == null)
            {
                return NotFound();
            }

            _context.SectorEmpresarial.Remove(sectorEmpresarialDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SectorEmpresarialDetailExists(int id)
        {
            return (_context.SectorEmpresarial?.Any(e => e.CodSector == id)).GetValueOrDefault();
        }
    }
}
