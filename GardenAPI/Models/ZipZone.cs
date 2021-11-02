// using System.ComponentModel.DataAnnotations;


namespace GardenAPI.Models
{
  
  public class ZipZone
  {
    public ZipZone()
    {
    }
    public int ZipZoneId { get; set; }
    public int ZipCode { get; set; }
    public int Zone { get; set; }

    public ZipZone(int zipcode, int zone)
    {
      ZipCode = zipcode;
      Zone = zone;
    }
  }
}