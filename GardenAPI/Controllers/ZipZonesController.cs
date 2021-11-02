using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GardenAPI.Models;
using GardenAPI.Data;
using Microsoft.Extensions.Logging;

namespace GardenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZipZonesController : ControllerBase
    {
        // private readonly GardenAPIContext _context;
        private readonly GardenAPIContext _context;

        public ZipZonesController(GardenAPIContext context)
        {
            _context = context;
        }

        // GET: api/ZipZones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZipZone>>> GetZipZone()
        {
            return await _context.ZipZones.ToListAsync();
        }

        // GET: api/ZipZones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZipZone>> GetZipZone(int id)
        {
            var zipZone = await _context.ZipZones.FindAsync(id);

            if (zipZone == null)
            {
                return NotFound();
            }

            return zipZone;
        }

        private bool ZipZoneExists(int id)
        {
            return _context.ZipZones.Any(e => e.ZipCode == id);
        }
    }
}
