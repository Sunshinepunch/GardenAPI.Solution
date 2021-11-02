using GardenAPI.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;


namespace GardenAPI.Data
{
  public class ZipZoneSeeder
  {
    private readonly GardenAPIContext _db;
    private readonly IWebHostEnvironment _env;
    public ZipZoneSeeder(GardenAPIContext db, IWebHostEnvironment env)
    {
      _db = db;
      _env = env;
    }
    private string GetData()
    {
      string rootPath = _env.ContentRootPath;
      string filePath = Path.GetFullPath(Path.Combine(rootPath, "Data", "zip_zone.json"));
      using (var r = new StreamReader(filePath))
      {
        string json = r.ReadToEnd();
        return json;
      }
    }
    public void Seed()
    {
      string data = GetData();
      var items = JsonSerializer.Deserialize<List<Dictionary<string, int>>>(data);
      foreach (var item in items)
      {
        var s = new ZipZone(item["zipcode"], item["zone"]);
        _db.ZipZones.Add(s);
      }
      _db.SaveChanges();
    }
  }

}