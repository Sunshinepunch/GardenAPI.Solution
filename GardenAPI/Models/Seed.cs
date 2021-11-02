namespace GardenAPI.Models
{
  public class Seed
  {
    public Seed()
    {
    }
    public int SeedId { get; set; }
    public string SeedName { get; set; }
    public int SqFootPlant { get; set; }
    public int DaysTillHarvest { get; set; }
    public int WaterInterval { get; set; }
    public int DaysTillSprout { get; set; }
    public string Companions { get; set; }
    public string Enemies { get; set; }

    public Seed(string seedname, int sqfootplant, int daystillharvest, int waterinterval,
               int daystillsprout, string companions, string enemies)
    {
      SeedName = seedname;
      SqFootPlant = sqfootplant;
      DaysTillHarvest = daystillharvest;
      WaterInterval = waterinterval;
      DaysTillSprout = daystillsprout;
      Companions = companions;
      Enemies = enemies;
    }
  }
}