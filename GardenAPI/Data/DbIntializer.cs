using Microsoft.AspNetCore.Hosting;
using System.Linq;


namespace GardenAPI.Data
{
  public class DbInitializer
  {
  
    private readonly GardenAPIContext _db;
    private readonly IWebHostEnvironment _env;
    public DbInitializer(GardenAPIContext db, IWebHostEnvironment env)
    {
      _db = db;
      _env = env;
    }

    // If no data for ZipZones exists in the db, seed it with zip_zone.json
    public void Seed()
    {
      _db.Database.EnsureCreated();
      if (!_db.ZipZones.Any())
      {
        var ZipZoneSeeder = new ZipZoneSeeder(_db, _env);
        ZipZoneSeeder.Seed();
      }
    }
  }

}