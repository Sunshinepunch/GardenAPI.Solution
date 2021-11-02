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
    public class SeedsController : ControllerBase
    {
        private readonly GardenAPIContext _context;

        public SeedsController(GardenAPIContext context)
        {
            _context = context;
        }

        // GET: api/Seeds
        // default returns all seeds, certain search terms are allowed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seed>>> Get(string seedname,
                        string companions, string enemies, string notes, string zone)
        {
            var query = _context.Seeds.AsQueryable();

            if (seedname != null)
            {
                query = query.Where(entry => entry.SeedName == seedname);
            }
            if (companions != null)
            {
                query = query.Where(entry => entry.Companions.Contains(companions));
            }
            if (enemies != null)
            {
                query = query.Where(entry => entry.Enemies.Contains(enemies));
            }
            if (zone != null)
            {
                query = query.Where(entry => entry.Zone.Contains(zone));
            }

            List<Seed> seedList = await query.ToListAsync();

            if(seedList.Count() < 1)
            {
                return BadRequest();
            }

            return seedList;
        }

        // GET: api/Seeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seed>> GetSeed(int id)
        {
            var seed = await _context.Seeds.FindAsync(id);

            if (seed == null)
            {
                return NotFound();
            }

            return seed;
        }

        // PUT: api/Seeds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeed(int id, Seed seed)
        {
            if (id != seed.SeedId)
            {
                return BadRequest();
            }

            _context.Entry(seed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeedExists(id))
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

        // POST: api/Seeds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Seed>> PostSeed(Seed seed)
        {
            _context.Seeds.Add(seed);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeed", new { id = seed.SeedId }, seed);
        }

        // DELETE: api/Seeds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeed(int id)
        {
            var seed = await _context.Seeds.FindAsync(id);
            if (seed == null)
            {
                return NotFound();
            }

            _context.Seeds.Remove(seed);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SeedExists(int id)
        {
            return _context.Seeds.Any(e => e.SeedId == id);
        }
    }
}
