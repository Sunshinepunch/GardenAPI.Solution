using GardenAPI.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;


namespace GardenAPI.Data
{
  public class SeedSeeder
  {
    private readonly GardenAPIContext _db;
    private readonly IWebHostEnvironment _env;
    public SeedSeeder(GardenAPIContext db, IWebHostEnvironment env)
    {
      _db = db;
      _env = env;
    }
    private string GetData()
    {
      string rootPath = _env.ContentRootPath;
      string filePath = Path.GetFullPath(Path.Combine(rootPath, "Data", "seed_data.json"));
      using (var r = new StreamReader(filePath))
      {
        string json = r.ReadToEnd();
        return json;
      }
    }
    public void Seed()
    {
      string data = GetData();
      var items = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(data);
      foreach (var item in items)
      {
        var s = new Seed(item["seedname"], item["sqfootplant"], item["daystillharvest"],
                        item["waterinterval"], item["daystillsprout"], item["companions"],
                        item["enemies"], item["notes"]);
        _db.Seeds.Add(s);
      }
      _db.SaveChanges();
    }
  }

}