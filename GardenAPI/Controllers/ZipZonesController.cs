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
        
        // zipcode is required, getting all zipzones at once breaks api
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZipZone>>> Get(int zipcode)
        {
            var query = _context.ZipZones.AsQueryable();

            if (zipcode > 0 && zipcode != 0)
            {
                query = query.Where(entry => entry.ZipCode == zipcode);
            }

            List<ZipZone> zipZone = await query.ToListAsync();

            if(zipZone.Count() < 1)
            {
                return BadRequest();
            }

            return zipZone;
        }

        // ZipZones will not have any PUT, PATCH, DELETE, etc., since
        // we don't want users to be able to change Zip Codes. Only GET one zipcode at a time.
    }
}
