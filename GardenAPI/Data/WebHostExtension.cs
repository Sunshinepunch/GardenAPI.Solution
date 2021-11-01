using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;


namespace GardenAPI.Data{

  public static class WebHostExtensions
  {
    public static IWebHost SeedData(this IWebHost host)
    {
      using (var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;
        try
        {
          var context = services.GetRequiredService<GardenAPIContext>();
          var env = services.GetRequiredService<IWebHostEnvironment>();
          var seeder = new DbInitializer(context, env);
          seeder.Seed();
        }
        catch (Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred initializing the DB.");
        }
      }
      return host;
    }
  }
}