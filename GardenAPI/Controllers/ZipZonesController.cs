using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GardenAPI.Models;

namespace GardenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZipZonesController : ControllerBase
    {
        private readonly GardenAPIContext _context;

        public ZipZonesController(GardenAPIContext context)
        {
            _context = context;
        }

        // GET: api/ZipZones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZipZone>>> GetZipZone()
        {
            return await _context.ZipZone.ToListAsync();
        }

        // GET: api/ZipZones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZipZone>> GetZipZone(int id)
        {
            var zipZone = await _context.ZipZone.FindAsync(id);

            if (zipZone == null)
            {
                return NotFound();
            }

            return zipZone;
        }

        // PUT: api/ZipZones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZipZone(int id, ZipZone zipZone)
        {
            if (id != zipZone.ZipZoneId)
            {
                return BadRequest();
            }

            _context.Entry(zipZone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZipZoneExists(id))
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

        // POST: api/ZipZones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ZipZone>> PostZipZone(ZipZone zipZone)
        {
            _context.ZipZone.Add(zipZone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZipZone", new { id = zipZone.ZipZoneId }, zipZone);
        }

        // DELETE: api/ZipZones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZipZone(int id)
        {
            var zipZone = await _context.ZipZone.FindAsync(id);
            if (zipZone == null)
            {
                return NotFound();
            }

            _context.ZipZone.Remove(zipZone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZipZoneExists(int id)
        {
            return _context.ZipZone.Any(e => e.ZipZoneId == id);
        }
    }
}
