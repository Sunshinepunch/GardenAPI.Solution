using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using GardenAPI.Data;
using Microsoft.AspNetCore;

namespace GardenAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().SeedData().Run();
        }

          public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
            }
}

