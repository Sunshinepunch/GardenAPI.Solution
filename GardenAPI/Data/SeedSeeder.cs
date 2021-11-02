// using GardenAPI.Models;
// using Microsoft.AspNetCore.Hosting;
// using System.Collections.Generic;
// using System.Text.Json;
// using System.IO;


// namespace GardenAPI.Data
// {
//   public class SeedSeeder
//   {
//     private readonly GardenAPIContext _db;
//     private readonly IWebHostEnvironment _env;
//     public SeedSeeder(GardenAPIContext db, IWebHostEnvironment env)
//     {
//       _db = db;
//       _env = env;
//     }

//     // Define file path to data on seeds, return raw json
//     private string GetData()
//     {
//       string rootPath = _env.ContentRootPath;
//       string filePath = Path.GetFullPath(Path.Combine(rootPath, "Data", "seed_data.json"));
//       using (var r = new StreamReader(filePath))
//       {
//         string json = r.ReadToEnd();
//         return json;
//       }
//     }


//   }

// }