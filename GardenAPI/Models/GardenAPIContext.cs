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
        builder.Entity<Seed>()
        .HasData
        (    
        new Seed 
        { 
        SeedId = 1,
        SeedName = "pole beans",
        SqFootPlant = 4,
        DaysTillHarvest = 80,
        WaterInterval = 3,
        DaysTillSprout = 10,
        Companions = "carrot, catnip, celery, chamomile, corn, cucumber, marigold, nasturtium, oregano",
        Enemies = "chives, garlic, leek, onion",
        Notes = "full sun, direct sow outdoors",
        Zone = "2, 3, 4, 5, 6, 7, 8, 9, 10, 11"
        },
        new Seed {
        SeedId = 2,
        SeedName = "tomato",
        SqFootPlant = 1,
        DaysTillHarvest = 85,
        WaterInterval = 1,
        DaysTillSprout = 10,
        Companions = "basil, garlic, parsley, amaranth, carrot, borage, marigold, onion, sage, cucumber",
        Enemies = "cabbage, broccoli, fennel, corn, kale, dill, pepper, eggplant, potato, brussel sprouts, cauliflower, collards, kholrabi,",
        Notes = "full sun, start indoors and transplant",
        Zone = "5, 6, 7, 8, 9, 10, 11"
        },
        new Seed {
        SeedId = 3,
        SeedName = "radish",
        SqFootPlant = 16,
        DaysTillHarvest = 60,
        WaterInterval = 5,
        DaysTillSprout = 4,
        Companions = "lettuce, tomato, carrot, onion, pepper, peas, cucumber, spinach",
        Enemies = "cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi, hyssop, turnip",
        Notes = "full sun,  direct sow outdoors",
        Zone = "5, 6, 7, 8, 9"
        },
        new Seed{
        SeedId = 4,
        SeedName = "corn",
        SqFootPlant = 4,
        DaysTillHarvest = 100,
        WaterInterval = 5,
        DaysTillSprout = 14,
        Companions = "borage, cucumber, dill, melon, marigold, pole beans, nasturtium",
        Enemies = "cabbage, broccoli, fennel, kale, pepper, eggplant, brussel sprouts, cauliflower, collards, kholrabi,",
        Notes = "full sun, start indoors and transplant or direct seed outdoors",
        Zone = "4, 5, 6, 7, 8, 9"
        },
        new Seed
        {
        SeedId = 5,
        SeedName = "spinach",
        SqFootPlant = 9,
        DaysTillHarvest = 45,
        WaterInterval = 2,
        DaysTillSprout = 5,
        Companions = "cabbage, kale, cauliflower, collards, eggplant, leek, lettuce, brussels sprouts, kohlrabi, asparagus, strawberries, radish, beans, peas, nasturtium, petunia, marigold",
        Enemies = "sunflowers, fennel, pumpkins, melons, corn, potatoes",
        Notes = "full sun, direct sow outdoors",
        Zone = "2, 3, 4, 5, 6, 7, 8, 9"
        },
        new Seed 
        {
        SeedId = 6,
        SeedName = "loose-leaf lettuce",
        SqFootPlant = 4,
        DaysTillHarvest = 45,
        WaterInterval = 4,
        DaysTillSprout = 10,
        Companions = "chives, garlic, marigold, beet, carrot, parsnip, onion, strawberries, corn, eggplant, tomato, corn, asparagus, peas, radish",
        Enemies = "cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi",
        Notes = "full sun, direct sow outdoors",
        Zone = "2, 3, 4, 5, 6, 7, 8, 9"
        },

        new Seed 
        {
        SeedId = 7,
        SeedName = "onion",
        SqFootPlant = 4,
        DaysTillHarvest = 90,
        WaterInterval = 3,
        DaysTillSprout = 10,
        Companions = "cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi, carrot, leek, beet, strawberries",
        Enemies = "peas, pole beans, bush beans, asparagus",
        Notes = "full sun, direct sow or from bulb outdoors",
        Zone = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11"
        },
        new Seed 
        {
        SeedId = 8,
        SeedName = "watermelon",
        SqFootPlant = 1,
        DaysTillHarvest = 90,
        WaterInterval = 3,
        DaysTillSprout = 12,
        Companions = "peas, pole beans, bush beans, onions, leeks, chives, and garlic, cabbage, broccoli, cauliflower, carrots, kale, okra, spinach, sunflowers, lettuce, brussels sprouts",
        Enemies = "any new plants grown by seed (watermelons release chemicals that inhibit seed growth)",
        Notes = "full sun, start indoors and transplant",
        Zone = "3, 4, 5, 6, 7, 8, 9, 10, 11"
        },
        new Seed 
        {
        SeedId = 9,
        SeedName = "pumpkin",
        SqFootPlant = 1,
        DaysTillHarvest = 120,
        WaterInterval = 3,
        DaysTillSprout = 10,
        Companions = "corn, beans, radish, nasturtium, aromatic herbs",
        Enemies = "beet, onion, potato, cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi",
        Notes = "full sun, direct sow outdoors",
        Zone = "3, 4, 5, 6, 7"
        });
        
    }

}