using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GardenAPI.Models;
using CsvHelper;
using System.IO;


public class GardenAPIContext : DbContext
{
    public GardenAPIContext (DbContextOptions<GardenAPIContext> options)
        : base(options)
    {
    }

    public DbSet<GardenAPI.Models.ZipZone> ZipZones { get; set; }
    public DbSet<GardenAPI.Models.Seed> Seeds { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {

    }
}

    
