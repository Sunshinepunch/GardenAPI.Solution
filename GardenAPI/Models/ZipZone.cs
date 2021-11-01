// using System.ComponentModel.DataAnnotations;


namespace GardenAPI.Models
{
  
  public class ZipZone
  {
    public int ZipZoneId { get; set; }
    public int ZipCode { get; set; }
    public int Zone { get; set; }

    public ZipZone(int zipZoneId, int zipcode, int zone)
    {
      ZipZoneId = zipZoneId;
      ZipCode = zipcode;
      Zone = zone;
    }
  }
}