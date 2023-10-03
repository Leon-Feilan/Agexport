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
    public class Detalle_Colaborador_SectorMainController : ControllerBase
    {
        private readonly MainContext _context;

        public Detalle_Colaborador_SectorMainController(MainContext context)
        {
            _context = context;
        }

        // GET: api/Detalle_Colaborador_SectorMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_Colaborador_SectorDetail>>> GetDetalle_Colaborador_Sector()
        {
          if (_context.Detalle_Colaborador_Sector == null)
          {
              return NotFound();
          }
            return await _context.Detalle_Colaborador_Sector.ToListAsync();
        }

        // GET: api/Detalle_Colaborador_SectorMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_Colaborador_SectorDetail>> GetDetalle_Colaborador_SectorDetail(int id)
        {
          if (_context.Detalle_Colaborador_Sector == null)
          {
              return NotFound();
          }
            var detalle_Colaborador_SectorDetail = await _context.Detalle_Colaborador_Sector.FindAsync(id);

            if (detalle_Colaborador_SectorDetail == null)
            {
                return NotFound();
            }

            return detalle_Colaborador_SectorDetail;
        }

        // PUT: api/Detalle_Colaborador_SectorMain/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle_Colaborador_SectorDetail(int id, Detalle_Colaborador_SectorDetail detalle_Colaborador_SectorDetail)
        {
            if (id != detalle_Colaborador_SectorDetail.OmitId)
            {
                return BadRequest();
            }

            _context.Entry(detalle_Colaborador_SectorDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_Colaborador_SectorDetailExists(id))
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

        // POST: api/Detalle_Colaborador_SectorMain
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_Colaborador_SectorDetail>> PostDetalle_Colaborador_SectorDetail(Detalle_Colaborador_SectorDetail detalle_Colaborador_SectorDetail)
        {
          if (_context.Detalle_Colaborador_Sector == null)
          {
              return Problem("Entity set 'MainContext.Detalle_Colaborador_Sector'  is null.");
          }
            _context.Detalle_Colaborador_Sector.Add(detalle_Colaborador_SectorDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalle_Colaborador_SectorDetail", new { id = detalle_Colaborador_SectorDetail.OmitId }, detalle_Colaborador_SectorDetail);
        }

        // DELETE: api/Detalle_Colaborador_SectorMain/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle_Colaborador_SectorDetail(int id)
        {
            if (_context.Detalle_Colaborador_Sector == null)
            {
                return NotFound();
            }
            var detalle_Colaborador_SectorDetail = await _context.Detalle_Colaborador_Sector.FindAsync(id);
            if (detalle_Colaborador_SectorDetail == null)
            {
                return NotFound();
            }

            _context.Detalle_Colaborador_Sector.Remove(detalle_Colaborador_SectorDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalle_Colaborador_SectorDetailExists(int id)
        {
            return (_context.Detalle_Colaborador_Sector?.Any(e => e.OmitId == id)).GetValueOrDefault();
        }
    }
}
